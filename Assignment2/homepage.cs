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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new welcome()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            (new loginform()).Show();
        }
    }
}
