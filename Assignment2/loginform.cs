using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin")
            {
                if (password.Text == "123")
                {
                    this.Hide();
                    (new homepage()).Show();
                }
                else
                {
                    usernameErr.Text = "";
                    passwordErr.Text = "Incorrect Password.";
                }
            }
            else
            {
                passwordErr.Text = "";
                usernameErr.Text = "Incorrect Username.";
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Username: admin\nPassword: 123");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new welcome()).Show();
        }
    }
}
