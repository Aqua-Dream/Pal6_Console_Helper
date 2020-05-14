using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Windows.Forms;

namespace 仙剑6控制台辅助工具
{
    public partial class Helper : Form
    {
        public Helper(List<XElement> d)
        {
            InitializeComponent();
            Datas = d;
            textBox1_TextChanged(null, null);
        }

        private List<XElement> Datas;

        private void AddItem(XElement e)
        {
            int index=dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = e.Attribute("Name").Value;
            dataGridView1.Rows[index].Cells[1].Value = e.Attribute("Use").Value;
            dataGridView1.Rows[index].Cells[2].Value = e.Attribute("Help").Value;
        }

        private void Helper_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Invoke((Action)delegate
            {
                dataGridView1.Rows.Clear();
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    foreach (XElement ele in Datas)
                    {
                        AddItem(ele);
                    }
                }
                else
                {
                    foreach (XElement ele in Datas)
                    {
                        if (ele.Attribute("Name").Value.IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            AddItem(ele);
                        }
                    }
                }
            });

        }

        private void 保存修改_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text))
            {
                if (MessageBox.Show("您设置了过滤，保存后将只剩下表中显示的命令。确定吗？", "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            Datas.Clear();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[0].Value!=null)
                {
                    XElement ele = new XElement(
                        "Data",
                        new XAttribute("Name", row.Cells[0].Value),
                        new XAttribute("Use", (row.Cells[1].Value== null)? "": row.Cells[1].Value),
                        new XAttribute("Help", (row.Cells[2].Value == null) ? "" : row.Cells[2].Value));
                    Datas.Add(ele);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
            ab.Dispose();
        }
    }
}
