namespace Assignment2
{
    partial class q3dashboard
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
            label1 = new Label();
            label2 = new Label();
            bookIn = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 98);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(40, 31);
            label2.Name = "label2";
            label2.Size = new Size(375, 32);
            label2.TabIndex = 1;
            label2.Text = "Library Book Borrowing System";
            // 
            // book
            // 
            bookIn.Location = new Point(100, 90);
            bookIn.Name = "bookIn";
            bookIn.Size = new Size(100, 23);
            bookIn.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(40, 157);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(169, 157);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 3;
            button2.Text = "Borrow Books";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(315, 157);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 3;
            button3.Text = "View Borrowed";
            button3.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(25, 231);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(32, 15);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Back";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // q3dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(464, 321);
            Controls.Add(linkLabel2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bookIn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "q3dashboard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox bookIn;
        private Button button1;
        private Button button2;
        private Button button3;
        private LinkLabel linkLabel2;
    }
}