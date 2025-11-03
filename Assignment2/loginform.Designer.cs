namespace Assignment2
{
    partial class loginform
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
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label3 = new Label();
            loginbtn = new Button();
            usernameErr = new Label();
            passwordErr = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(141, 53);
            username.Name = "username";
            username.Size = new Size(100, 23);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(141, 107);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 61);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 107);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 257);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(86, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Welcome Page";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(288, 61);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(30, 15);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Hint";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(162, 9);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 7;
            label3.Text = "LogIn";
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(113, 157);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(75, 23);
            loginbtn.TabIndex = 8;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += button1_Click;
            // 
            // usernameErr
            // 
            usernameErr.AutoSize = true;
            usernameErr.ForeColor = Color.Red;
            usernameErr.Location = new Point(141, 77);
            usernameErr.Name = "usernameErr";
            usernameErr.Size = new Size(0, 15);
            usernameErr.TabIndex = 9;
            // 
            // passwordErr
            // 
            passwordErr.AutoSize = true;
            passwordErr.ForeColor = Color.Red;
            passwordErr.Location = new Point(141, 133);
            passwordErr.Name = "passwordErr";
            passwordErr.Size = new Size(0, 15);
            passwordErr.TabIndex = 10;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(464, 321);
            Controls.Add(passwordErr);
            Controls.Add(usernameErr);
            Controls.Add(loginbtn);
            Controls.Add(label3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Name = "loginform";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label3;
        private Button loginbtn;
        private Label usernameErr;
        private Label passwordErr;
    }
}