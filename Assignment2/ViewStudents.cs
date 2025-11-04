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
    public partial class ViewStudents : Form
    {
        BindingList<Student> students;
        public ViewStudents(BindingList<Student> s)
        {
            InitializeComponent();
            dataGridView1.DataSource = students = s;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new q2dashboard(students)).Show();
        }
    }
}
