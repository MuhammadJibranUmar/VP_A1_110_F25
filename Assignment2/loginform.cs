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
        private int programNumber;
        public loginform(int n)
        {
            InitializeComponent();
            programNumber = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin")
            {
                if (password.Text == "1234")
                {
                    this.Hide();
                    switch (programNumber)
                    {
                        case 1:
                            (new homepage()).Show();
                            break;
                        case 2:
                            break;
                        case 3:
                            (new homepage()).Show();
                            break;
                        case 4:
                            break;
                        case 5:
                            (new homepage()).Show();
                            break;
                        case 6:
                            break;
                        case 7:
                            (new homepage()).Show();
                            break;
                        case 8:
                            break;
                        default:
                            break;
                    }
                    
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
            MessageBox.Show("Username: admin\nPassword: 1234");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new welcome()).Show();
        }
    }
}
