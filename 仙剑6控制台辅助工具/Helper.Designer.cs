namespace 仙剑6控制台辅助工具
{
    partial class Helper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helper));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.命令 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作用 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.参数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.保存修改 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.过滤 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.命令,
            this.作用,
            this.参数});
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(500, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // 命令
            // 
            this.命令.HeaderText = "命令";
            this.命令.Name = "命令";
            // 
            // 作用
            // 
            this.作用.HeaderText = "作用";
            this.作用.Name = "作用";
            // 
            // 参数
            // 
            this.参数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.参数.FillWeight = 200F;
            this.参数.HeaderText = "参数";
            this.参数.Name = "参数";
            this.参数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 保存修改
            // 
            this.保存修改.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.保存修改.Location = new System.Drawing.Point(320, 277);
            this.保存修改.Name = "保存修改";
            this.保存修改.Size = new System.Drawing.Size(75, 23);
            this.保存修改.TabIndex = 1;
            this.保存修改.Text = "保存修改";
            this.保存修改.UseVisualStyleBackColor = true;
            this.保存修改.Click += new System.EventHandler(this.保存修改_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(87, 279);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // 过滤
            // 
            this.过滤.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.过滤.AutoSize = true;
            this.过滤.Location = new System.Drawing.Point(22, 282);
            this.过滤.Name = "过滤";
            this.过滤.Size = new System.Drawing.Size(65, 12);
            this.过滤.TabIndex = 3;
            this.过滤.Text = "过滤文本：";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "关于";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.过滤);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.保存修改);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Helper";
            this.Text = "Helper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Helper_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 保存修改;
        private System.Windows.Forms.DataGridViewTextBoxColumn 命令;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作用;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参数;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label 过滤;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}