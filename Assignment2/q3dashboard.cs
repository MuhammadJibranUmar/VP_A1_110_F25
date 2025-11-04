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
    public partial class q3dashboard : Form
    {
        BindingList<Book> books;
        public q3dashboard()
        {
            InitializeComponent();
            books = new BindingList<Book>();
        }

        public q3dashboard(BindingList<Book> b)
        {
            InitializeComponent();
            books = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.bookName = bookIn.Text;
            book.isBorrowed = false;
            books.Add(book);

            MessageBox.Show("Book Added Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new BorrowBook(books)).Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new loginform(3)).Show();
        }
    }
}
