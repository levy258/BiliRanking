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
            this.reverseUpDownFpaiming = new ReverseUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.reverseUpDownFpaiming)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "{时间} {av号} {作者}",
            "{播放}{}{硬币}{}{收藏}{}{弹幕}{}{评论}",
            "{总分}",
            "{tag}",
            "{标题}"});
            this.comboBox1.Location = new System.Drawing.Point(46, 42);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "{时间} {av号} {作者}";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(15, 146);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(411, 22);
            this.buttonCopy.TabIndex = 1;
            this.buttonCopy.Text = "复制";
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
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "→";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(15, 70);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(411, 71);
            this.textBoxResult.TabIndex = 7;
            // 
            // reverseUpDownFpaiming
            // 
            this.reverseUpDownFpaiming.Location = new System.Drawing.Point(12, 10);
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
            this.ClientSize = new System.Drawing.Size(435, 179);
            this.Controls.Add(this.reverseUpDownFpaiming);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNow);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuickCopy";
            this.Text = "[置顶]快速复制ヽ(✿ﾟ▽ﾟ)ノ";
            this.TopMost = true;
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
    }
}