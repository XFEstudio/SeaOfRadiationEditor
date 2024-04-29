namespace SeaOfRadiationEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            checkBox2 = new CheckBox();
            textBox3 = new TextBox();
            checkBox3 = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(312, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 30);
            textBox1.TabIndex = 0;
            textBox1.Text = "99";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(205, 487);
            label1.Name = "label1";
            label1.Size = new Size(250, 31);
            label1.TabIndex = 4;
            label1.Text = "by bilibili UP:XFE菜狗";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(152, 560);
            label2.Name = "label2";
            label2.Size = new Size(370, 24);
            label2.TabIndex = 5;
            label2.Text = "声明：本修改器完全免费，如遇收费均为盗版";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft YaHei UI", 12F);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(130, 105);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 35);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "重置次数";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(64, 64, 64);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(312, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 30);
            textBox2.TabIndex = 11;
            textBox2.Text = "600";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft YaHei UI", 12F);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(130, 181);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(112, 35);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "倒计时";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += CheckBox2_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(64, 64, 64);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(312, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 30);
            textBox3.TabIndex = 13;
            textBox3.Text = "99";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Microsoft YaHei UI", 12F);
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(130, 269);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(88, 35);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "体力";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += CheckBox3_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(629, 623);
            Controls.Add(checkBox3);
            Controls.Add(textBox3);
            Controls.Add(checkBox2);
            Controls.Add(textBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "辐射之海：序章 3项修改器[未启动游戏]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        internal CheckBox checkBox1;
        internal CheckBox checkBox2;
        internal CheckBox checkBox3;
        internal TextBox textBox1;
        internal TextBox textBox2;
        internal TextBox textBox3;
    }
}
