namespace CodingTestProblemSelector
{
    partial class Form1
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
            this.collectProblenBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.timerBtn = new System.Windows.Forms.Button();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.programmersLabel = new System.Windows.Forms.LinkLabel();
            this.linkListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // collectProblenBtn
            // 
            this.collectProblenBtn.Location = new System.Drawing.Point(601, 180);
            this.collectProblenBtn.Name = "collectProblenBtn";
            this.collectProblenBtn.Size = new System.Drawing.Size(150, 60);
            this.collectProblenBtn.TabIndex = 0;
            this.collectProblenBtn.Text = "문제 가져오기";
            this.collectProblenBtn.Click += new System.EventHandler(this.collectProblenBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(601, 287);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(150, 60);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "결정";
            this.selectBtn.UseVisualStyleBackColor = true;
            // 
            // timerBtn
            // 
            this.timerBtn.Location = new System.Drawing.Point(601, 394);
            this.timerBtn.Name = "timerBtn";
            this.timerBtn.Size = new System.Drawing.Size(150, 60);
            this.timerBtn.TabIndex = 2;
            this.timerBtn.Text = "타이머";
            this.timerBtn.UseVisualStyleBackColor = true;
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Location = new System.Drawing.Point(40, 106);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(61, 24);
            this.checkBox0.TabIndex = 3;
            this.checkBox0.Text = "Lv. 0";
            this.checkBox0.UseVisualStyleBackColor = true;
            this.checkBox0.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(165, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Lv. 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(290, 106);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 24);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Lv. 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(415, 106);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 24);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Lv. 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(540, 106);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(61, 24);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Lv. 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(665, 106);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(61, 24);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "Lv. 5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // programmersLabel
            // 
            this.programmersLabel.AutoSize = true;
            this.programmersLabel.Location = new System.Drawing.Point(339, 33);
            this.programmersLabel.Name = "programmersLabel";
            this.programmersLabel.Size = new System.Drawing.Size(99, 20);
            this.programmersLabel.TabIndex = 9;
            this.programmersLabel.TabStop = true;
            this.programmersLabel.Text = "프로그래머스";
            this.programmersLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.programmersLabel_LinkClicked);
            // 
            // linkListBox
            // 
            this.linkListBox.FormattingEnabled = true;
            this.linkListBox.ItemHeight = 20;
            this.linkListBox.Location = new System.Drawing.Point(40, 180);
            this.linkListBox.Name = "linkListBox";
            this.linkListBox.Size = new System.Drawing.Size(519, 344);
            this.linkListBox.TabIndex = 10;
            this.linkListBox.SelectedIndexChanged += new System.EventHandler(this.linkListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.linkListBox);
            this.Controls.Add(this.programmersLabel);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox0);
            this.Controls.Add(this.timerBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.collectProblenBtn);
            this.Name = "Form1";
            this.Text = "프로그래머스 문제 은행";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button collectProblenBtn;
        private Button timerBtn;
        private Button selectBtn;
        private CheckBox checkBox0;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private LinkLabel programmersLabel;
        private ListBox linkListBox;
    }
}