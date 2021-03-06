﻿namespace BiliRanking
{
    partial class FormQuickCopy
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelNow = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLifetime12 = new System.Windows.Forms.Button();
            this.buttonLifetime30 = new System.Windows.Forms.Button();
            this.comboBoxLifeTime = new System.Windows.Forms.ComboBox();
            this.reverseUpDownFpaiming = new ReverseUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.reverseUpDownFpaiming)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "{标题}",
            "{时间} {av号} {作者}",
            "{播放}{}{硬币}{}{收藏}{}{弹幕}{}{评论}",
            "{总分}",
            "{tag}",
            "{时间}    {av号}    {作者}",
            "{代码}",
            "{时间码}"});
            this.comboBox1.Location = new System.Drawing.Point(45, 42);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "{标题}";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(15, 146);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(411, 22);
            this.buttonCopy.TabIndex = 1;
            this.buttonCopy.Text = "复制（通常不需要点，上面一旦改变会自动复制）";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelNow
            // 
            this.labelNow.AutoSize = true;
            this.labelNow.Location = new System.Drawing.Point(68, 18);
            this.labelNow.Name = "labelNow";
            this.labelNow.Size = new System.Drawing.Size(67, 15);
            this.labelNow.TabIndex = 3;
            this.labelNow.Text = "当前标题";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "→";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(15, 70);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(411, 72);
            this.textBoxResult.TabIndex = 7;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "蛤，←和→键已经被我拦截啦~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "时间码已经被+1s+1s，按钮显示时长:";
            // 
            // buttonLifetime12
            // 
            this.buttonLifetime12.Location = new System.Drawing.Point(349, 200);
            this.buttonLifetime12.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLifetime12.Name = "buttonLifetime12";
            this.buttonLifetime12.Size = new System.Drawing.Size(38, 24);
            this.buttonLifetime12.TabIndex = 11;
            this.buttonLifetime12.Text = "22";
            this.buttonLifetime12.UseVisualStyleBackColor = true;
            this.buttonLifetime12.Click += new System.EventHandler(this.buttonLifetime12_Click);
            // 
            // buttonLifetime30
            // 
            this.buttonLifetime30.Location = new System.Drawing.Point(388, 200);
            this.buttonLifetime30.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLifetime30.Name = "buttonLifetime30";
            this.buttonLifetime30.Size = new System.Drawing.Size(38, 24);
            this.buttonLifetime30.TabIndex = 12;
            this.buttonLifetime30.Text = "34";
            this.buttonLifetime30.UseVisualStyleBackColor = true;
            this.buttonLifetime30.Click += new System.EventHandler(this.buttonLifetime30_Click);
            // 
            // comboBoxLifeTime
            // 
            this.comboBoxLifeTime.FormattingEnabled = true;
            this.comboBoxLifeTime.Items.AddRange(new object[] {
            "18",
            "22",
            "26",
            "32",
            "34",
            "36"});
            this.comboBoxLifeTime.Location = new System.Drawing.Point(276, 201);
            this.comboBoxLifeTime.Name = "comboBoxLifeTime";
            this.comboBoxLifeTime.Size = new System.Drawing.Size(70, 23);
            this.comboBoxLifeTime.TabIndex = 13;
            this.comboBoxLifeTime.TextChanged += new System.EventHandler(this.comboBoxLifeTime_TextChanged);
            // 
            // reverseUpDownFpaiming
            // 
            this.reverseUpDownFpaiming.Location = new System.Drawing.Point(12, 10);
            this.reverseUpDownFpaiming.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reverseUpDownFpaiming.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.reverseUpDownFpaiming.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reverseUpDownFpaiming.Name = "reverseUpDownFpaiming";
            this.reverseUpDownFpaiming.Size = new System.Drawing.Size(56, 25);
            this.reverseUpDownFpaiming.TabIndex = 8;
            this.reverseUpDownFpaiming.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reverseUpDownFpaiming.ValueChanged += new System.EventHandler(this.reverseUpDownFpaiming_ValueChanged);
            // 
            // FormQuickCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 229);
            this.Controls.Add(this.comboBoxLifeTime);
            this.Controls.Add(this.buttonLifetime30);
            this.Controls.Add(this.buttonLifetime12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reverseUpDownFpaiming);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNow);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuickCopy";
            this.Text = "[置顶]快速复制ヽ(✿ﾟ▽ﾟ)ノ";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuickCopy_FormClosing);
            this.Load += new System.EventHandler(this.FormQuickCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reverseUpDownFpaiming)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelNow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxResult;
        private ReverseUpDown reverseUpDownFpaiming;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLifetime12;
        private System.Windows.Forms.Button buttonLifetime30;
        private System.Windows.Forms.ComboBox comboBoxLifeTime;
    }
}