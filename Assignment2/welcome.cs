namespace Assignment2
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new loginform()).Show();
        }
    }
}
