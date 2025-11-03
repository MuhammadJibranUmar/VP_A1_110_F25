namespace Assignment2
{
    partial class welcome
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            linkLabel6 = new LinkLabel();
            linkLabel7 = new LinkLabel();
            linkLabel8 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(89, 25);
            label1.Name = "label1";
            label1.Size = new Size(273, 32);
            label1.TabIndex = 0;
            label1.Text = "Assignment 2 Solution";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(24, 86);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(86, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Question No. 1";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += this.linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(24, 172);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(86, 15);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Question No. 4";
            linkLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(24, 142);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(86, 15);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Question No. 3";
            linkLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(24, 113);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(86, 15);
            linkLabel4.TabIndex = 4;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Question No. 2";
            linkLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Location = new Point(163, 86);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(86, 15);
            linkLabel5.TabIndex = 1;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Question No. 5";
            linkLabel5.TextAlign = ContentAlignment.MiddleCenter;
           // linkLabel5.LinkClicked += this.linkLabel5_LinkClicked;
            // 
            // linkLabel6
            // 
            linkLabel6.AutoSize = true;
            linkLabel6.Location = new Point(163, 172);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(86, 15);
            linkLabel6.TabIndex = 2;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "Question No. 8";
            linkLabel6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel7
            // 
            linkLabel7.AutoSize = true;
            linkLabel7.Location = new Point(163, 142);
            linkLabel7.Name = "linkLabel7";
            linkLabel7.Size = new Size(86, 15);
            linkLabel7.TabIndex = 3;
            linkLabel7.TabStop = true;
            linkLabel7.Text = "Question No. 7";
            linkLabel7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel8
            // 
            linkLabel8.AutoSize = true;
            linkLabel8.Location = new Point(163, 113);
            linkLabel8.Name = "linkLabel8";
            linkLabel8.Size = new Size(86, 15);
            linkLabel8.TabIndex = 4;
            linkLabel8.TabStop = true;
            linkLabel8.Text = "Question No. 6";
            linkLabel8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 321);
            Controls.Add(linkLabel8);
            Controls.Add(linkLabel7);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel6);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "welcome";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel6;
        private LinkLabel linkLabel7;
        private LinkLabel linkLabel8;
    }
}
