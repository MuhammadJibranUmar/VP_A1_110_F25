namespace Assignment2
{
    partial class BorrowBook
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            bookList = new CheckedListBox();
            linkLabel2 = new LinkLabel();
            borrowedList = new ListBox();
            bookBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(125, 28);
            label2.Name = "label2";
            label2.Size = new Size(183, 32);
            label2.TabIndex = 2;
            label2.Text = "Borrow a Book";
            // 
            // bookList
            // 
            bookList.FormattingEnabled = true;
            bookList.Location = new Point(12, 73);
            bookList.Name = "bookList";
            bookList.Size = new Size(160, 148);
            bookList.TabIndex = 4;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(12, 265);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(32, 15);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Back";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // borrowedList
            // 
            borrowedList.DataSource = bookBindingSource;
            borrowedList.FormattingEnabled = true;
            borrowedList.ItemHeight = 15;
            borrowedList.Location = new Point(244, 73);
            borrowedList.Name = "borrowedList";
            borrowedList.Size = new Size(160, 139);
            borrowedList.TabIndex = 8;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            bookBindingSource.CurrentChanged += bookBindingSource_CurrentChanged;
            // 
            // BorrowBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(464, 321);
            Controls.Add(borrowedList);
            Controls.Add(linkLabel2);
            Controls.Add(bookList);
            Controls.Add(label2);
            Name = "BorrowBook";
            Text = "BorrowBook";
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private CheckedListBox bookList;
        private LinkLabel linkLabel2;
        private ListBox borrowedList;
        private BindingSource bookBindingSource;
    }
}