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
    public partial class q2dashboard : Form
    {
        BindingList<Student> students;

        public q2dashboard()
        {
            InitializeComponent();
            students = new BindingList<Student>();
        }

        public q2dashboard(BindingList<Student> s)
        {
            InitializeComponent();
            students = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new loginform(2)).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new AddStudent(students)).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new ViewStudents(students)).Show();
        }
    }
}
