using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class BorrowForm : Form
    {
        public static BorrowForm instance;
            public BorrowForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void reqButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to borrow this book", "Borrow book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reqButton.Text = "Borrowed";
                reqButton.BackColor = SystemColors.ActiveBorder;
            }
        }

        private void navLabel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
