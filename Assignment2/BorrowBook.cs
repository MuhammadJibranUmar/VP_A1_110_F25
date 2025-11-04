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
    public partial class BorrowBook : Form
    {
        BindingList<Book> books;
        BindingList<Book> bBooks = new BindingList<Book>();
        public BorrowBook()
        {
            InitializeComponent();
        }
        public BorrowBook(BindingList<Book> b)
        {
            InitializeComponent();
            books = b;
            bookList.DataSource = books;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new q3dashboard(books)).Show();
        }

        private void bookBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
