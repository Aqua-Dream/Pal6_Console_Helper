using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace 仙剑6控制台辅助工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                XElement Root = XElement.Load("Pal6_Console_Helper.xml");
                XElement Config = Root.Element("Config");
                pathTextBox.Text = Config.Attribute("Path").Value;
                string address = Config.Attribute("Address").Value;
                long.TryParse(address, out Address);
                Datas = Root.Elements("Data").ToList();
                pathTextBox_TextChanged(null, null);

            }
            catch
            {
                exitCorrectly = false;
                MessageBox.Show("配置文件丢失或损坏！请重新下载。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private List<XElement> Datas;

        private string dll = null;

        private long Address = 0;

        private bool open;

        public bool exitCorrectly = true;

        private byte IsAddress(byte[] buffer, int loc)   //返回值：0表示位置不对，否则返回temp[0]
        {
            if ((buffer[loc] == 0x16 || buffer[loc] == 0x17) && buffer[loc + 1] == 0x80 && buffer[loc + 6] == 0x1F && buffer[loc + 7] == 0x0F)
                return buffer[loc];
            return 0;
        }

        private void ButtonEnable(bool a, bool b, bool c)
        {
            searchButton.Enabled = a;
            changeButton.Enabled = b;
            beginGame.Enabled = c;
        }

        private void choosePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {
            dll = Path.Combine(pathTextBox.Text, @"Pal6_Data\Managed\Assembly-CSharp.dll");
            if (!File.Exists(Path.Combine(pathTextBox.Text, "Pal6.exe")))
            {
                statusLabel.Text = "找不到Pal6.exe！请确认目录是否正确！";
                ButtonEnable(false, false, false);
            }
            else if (!File.Exists(dll))
            {
                statusLabel.Text = "找不到Assembly-CSharp.dll！请确认目录是否正确！";
                ButtonEnable(false, false, true);
            }
            else
            {
                try
                {
                    FileStream f = File.OpenRead(dll);
                    f.Seek(Address, SeekOrigin.Begin);
                    byte[] buffer = new byte[8];
                    f.Read(buffer, 0, 8);
                    f.Close();
                    byte temp = IsAddress(buffer, 0);
                    if (temp == 0)
                    {
                        statusLabel.Text = "未记录正确的地址，请点击“查询状态”。";
                        ButtonEnable(true, false, true);
                    }
                    else if (temp == 0x16)
                    {
                        statusLabel.Text = "控制台状态：关闭";
                        open = false;
                        ButtonEnable(true, true, true);
                    }
                    else
                    {
                        statusLabel.Text = "控制台状态：打开";
                        open = true;
                        ButtonEnable(true, true, true);
                    }
                }
                catch
                {
                    statusLabel.Text = "暂时无法打开Assembly-CSharp.dll。请关闭游戏后，点击“查询状态”重试。";
                    ButtonEnable(true, false, true);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exitCorrectly)
            {
                XElement Root = new XElement
                (
                    "Pal6_Console_Helper",
                    new XElement(
                        "Config",
                        new XAttribute("Path", pathTextBox.Text),
                        new XAttribute("Address", Address.ToString())),
                    Datas
                );
                Root.Save("Pal6_Console_Helper.xml");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            int i = 0;
            byte temp = 0;
            try
            {
                FileStream f = File.OpenRead(dll);
                statusLabel.Text = "正在搜寻...";
                this.Enabled = false;
                int length = (int)f.Length;
                byte[] buffer = new byte[length];
                f.Read(buffer, 0, length);
                f.Close();
                for (i = 0; i <= length - 8; i++)
                {
                    temp = IsAddress(buffer, i);
                    if (temp != 0)
                    {
                        found = true;
                        break;
                    }
                }
                this.Enabled = true;
                if (found)
                {
                    Address = i;
                    open = temp == 0x17;
                    if (open)
                        statusLabel.Text = "控制台状态：打开";
                    else
                        statusLabel.Text = "控制台状态：关闭";
                    ButtonEnable(true, true, true);
                }
                else
                {
                    statusLabel.Text = "错误：找不到控制台相关信息！";
                    ButtonEnable(true, false, true);
                }
            }
            catch
            {
                statusLabel.Text = "暂时无法打开Assembly-CSharp.dll。请关闭游戏后，点击“查询状态”重试。";
                ButtonEnable(true, false, true);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            String open_status = open ? "打开" : "关闭";
            String open_status_inv = open ? "关闭" : "打开";
            String hint = String.Format("当前控制台为{0}状态，需要{1}吗？", open_status, open_status_inv);
            int b_inv = open ? 0x16 : 0x17;
            if (MessageBox.Show(hint, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try
                {
                    FileStream f = File.OpenWrite(dll);
                    f.Seek(Address, SeekOrigin.Begin);
                    f.WriteByte((byte)b_inv);
                    f.Close();
                    open = !open;
                    statusLabel.Text = String.Format("控制台状态：{0}", open_status_inv);
                }
                catch
                {
                    statusLabel.Text = "暂时无法修改Assembly-CSharp.dll。请关闭游戏、重启本程序再试。";
                }
            }
        }

        private void beginGame_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Path.Combine(pathTextBox.Text, "Pal6.exe"));
                statusLabel.Text = "游戏已经启动，您可以选择“查询命令”，或者关闭程序。";
                beginGame.Enabled = false;
                timer1.Enabled = true;
            }
            catch
            {
                statusLabel.Text = "启动失败！";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            beginGame.Invoke((Action)delegate
            {
                beginGame.Enabled = true;
            });
            timer1.Enabled = false;
        }

        private void helperButton_Click(object sender, EventArgs e)
        {
            Helper h = new Helper(Datas);
            h.Show(this);
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!exitCorrectly) this.Close();
        }
    }
}
