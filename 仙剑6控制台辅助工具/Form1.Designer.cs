namespace 仙剑6控制台辅助工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.choosePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.beginGame = new System.Windows.Forms.Button();
            this.helperButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(89, 24);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(261, 21);
            this.pathTextBox.TabIndex = 0;
            this.pathTextBox.TextChanged += new System.EventHandler(this.pathTextBox_TextChanged);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(25, 27);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(65, 12);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "游戏目录：";
            // 
            // choosePath
            // 
            this.choosePath.Location = new System.Drawing.Point(368, 22);
            this.choosePath.Name = "choosePath";
            this.choosePath.Size = new System.Drawing.Size(43, 23);
            this.choosePath.TabIndex = 2;
            this.choosePath.Text = "浏览";
            this.choosePath.UseVisualStyleBackColor = true;
            this.choosePath.Click += new System.EventHandler(this.choosePath_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(25, 119);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(77, 12);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "satatusLabel";
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(27, 71);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "查询状态";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(130, 71);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "修改状态";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // beginGame
            // 
            this.beginGame.Enabled = false;
            this.beginGame.Location = new System.Drawing.Point(234, 71);
            this.beginGame.Name = "beginGame";
            this.beginGame.Size = new System.Drawing.Size(75, 23);
            this.beginGame.TabIndex = 6;
            this.beginGame.Text = "启动游戏";
            this.beginGame.UseVisualStyleBackColor = true;
            this.beginGame.Click += new System.EventHandler(this.beginGame_Click);
            // 
            // helperButton
            // 
            this.helperButton.Location = new System.Drawing.Point(336, 71);
            this.helperButton.Name = "helperButton";
            this.helperButton.Size = new System.Drawing.Size(75, 23);
            this.helperButton.TabIndex = 7;
            this.helperButton.Text = "命令查询";
            this.helperButton.UseVisualStyleBackColor = true;
            this.helperButton.Click += new System.EventHandler(this.helperButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(440, 152);
            this.Controls.Add(this.helperButton);
            this.Controls.Add(this.beginGame);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.choosePath);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pal6_Console_Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button choosePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button beginGame;
        private System.Windows.Forms.Button helperButton;
        private System.Windows.Forms.Timer timer1;
    }
}

