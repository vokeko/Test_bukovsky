namespace Test_bukovsky
{
    partial class searchForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backButton2 = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.dayTextbox = new System.Windows.Forms.TextBox();
            this.monthTextbox = new System.Windows.Forms.TextBox();
            this.day2Textbox = new System.Windows.Forms.TextBox();
            this.month2Textbox = new System.Windows.Forms.TextBox();
            this.YearTextbox = new System.Windows.Forms.TextBox();
            this.year2Textbox = new System.Windows.Forms.TextBox();
            this.fromToCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hourTextbox = new System.Windows.Forms.TextBox();
            this.minuteTextbox = new System.Windows.Forms.TextBox();
            this.hour2Textbox = new System.Windows.Forms.TextBox();
            this.minute2Textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton2
            // 
            this.backButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton2.Location = new System.Drawing.Point(18, 237);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(94, 28);
            this.backButton2.TabIndex = 2;
            this.backButton2.Text = "Zpět";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(242, 237);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(94, 28);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Potvrdit";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // dayTextbox
            // 
            this.dayTextbox.Location = new System.Drawing.Point(18, 12);
            this.dayTextbox.Name = "dayTextbox";
            this.dayTextbox.Size = new System.Drawing.Size(94, 22);
            this.dayTextbox.TabIndex = 4;
            // 
            // monthTextbox
            // 
            this.monthTextbox.Location = new System.Drawing.Point(18, 40);
            this.monthTextbox.Name = "monthTextbox";
            this.monthTextbox.Size = new System.Drawing.Size(94, 22);
            this.monthTextbox.TabIndex = 5;
            // 
            // day2Textbox
            // 
            this.day2Textbox.Location = new System.Drawing.Point(190, 12);
            this.day2Textbox.Name = "day2Textbox";
            this.day2Textbox.Size = new System.Drawing.Size(94, 22);
            this.day2Textbox.TabIndex = 6;
            // 
            // month2Textbox
            // 
            this.month2Textbox.Location = new System.Drawing.Point(190, 40);
            this.month2Textbox.Name = "month2Textbox";
            this.month2Textbox.Size = new System.Drawing.Size(94, 22);
            this.month2Textbox.TabIndex = 7;
            // 
            // YearTextbox
            // 
            this.YearTextbox.Location = new System.Drawing.Point(18, 68);
            this.YearTextbox.Name = "YearTextbox";
            this.YearTextbox.Size = new System.Drawing.Size(94, 22);
            this.YearTextbox.TabIndex = 8;
            // 
            // year2Textbox
            // 
            this.year2Textbox.Location = new System.Drawing.Point(190, 68);
            this.year2Textbox.Name = "year2Textbox";
            this.year2Textbox.Size = new System.Drawing.Size(94, 22);
            this.year2Textbox.TabIndex = 9;
            // 
            // fromToCheck
            // 
            this.fromToCheck.AutoSize = true;
            this.fromToCheck.Location = new System.Drawing.Point(140, 240);
            this.fromToCheck.Name = "fromToCheck";
            this.fromToCheck.Size = new System.Drawing.Size(78, 21);
            this.fromToCheck.TabIndex = 10;
            this.fromToCheck.Text = "Od - do";
            this.fromToCheck.UseVisualStyleBackColor = true;
            this.fromToCheck.CheckedChanged += new System.EventHandler(this.fromToCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Den";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Měsíc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Den";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Měsíc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Do";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Od";
            // 
            // hourTextbox
            // 
            this.hourTextbox.Location = new System.Drawing.Point(18, 96);
            this.hourTextbox.Name = "hourTextbox";
            this.hourTextbox.Size = new System.Drawing.Size(94, 22);
            this.hourTextbox.TabIndex = 19;
            // 
            // minuteTextbox
            // 
            this.minuteTextbox.Location = new System.Drawing.Point(18, 124);
            this.minuteTextbox.Name = "minuteTextbox";
            this.minuteTextbox.Size = new System.Drawing.Size(94, 22);
            this.minuteTextbox.TabIndex = 20;
            // 
            // hour2Textbox
            // 
            this.hour2Textbox.Location = new System.Drawing.Point(190, 96);
            this.hour2Textbox.Name = "hour2Textbox";
            this.hour2Textbox.Size = new System.Drawing.Size(94, 22);
            this.hour2Textbox.TabIndex = 21;
            // 
            // minute2Textbox
            // 
            this.minute2Textbox.Location = new System.Drawing.Point(190, 124);
            this.minute2Textbox.Name = "minute2Textbox";
            this.minute2Textbox.Size = new System.Drawing.Size(94, 22);
            this.minute2Textbox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Hodina";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Hodina";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Minuty";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Minuty";
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.backButton2;
            this.ClientSize = new System.Drawing.Size(348, 277);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minute2Textbox);
            this.Controls.Add(this.hour2Textbox);
            this.Controls.Add(this.minuteTextbox);
            this.Controls.Add(this.hourTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromToCheck);
            this.Controls.Add(this.year2Textbox);
            this.Controls.Add(this.YearTextbox);
            this.Controls.Add(this.month2Textbox);
            this.Controls.Add(this.day2Textbox);
            this.Controls.Add(this.monthTextbox);
            this.Controls.Add(this.dayTextbox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.backButton2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "searchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hledání podle data";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.searchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox dayTextbox;
        private System.Windows.Forms.TextBox monthTextbox;
        private System.Windows.Forms.TextBox day2Textbox;
        private System.Windows.Forms.TextBox month2Textbox;
        private System.Windows.Forms.TextBox YearTextbox;
        private System.Windows.Forms.TextBox year2Textbox;
        private System.Windows.Forms.CheckBox fromToCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hourTextbox;
        private System.Windows.Forms.TextBox minuteTextbox;
        private System.Windows.Forms.TextBox hour2Textbox;
        private System.Windows.Forms.TextBox minute2Textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}