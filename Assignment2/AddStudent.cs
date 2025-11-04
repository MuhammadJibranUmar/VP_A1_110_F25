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
    public partial class AddStudent : Form
    {
        BindingList<Student> students;
        public AddStudent(BindingList<Student> s)
        {
            InitializeComponent();
            students = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = name.Text;
            student.Age = (Convert.ToInt32(age.Text));
            student.Clas = clas.Text;

            students.Add(student);
            MessageBox.Show("Student Added Successfully!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new welcome()).Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new q2dashboard(students)).Show();
        }
    }
}
