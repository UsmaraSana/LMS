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
    public partial class CheckoutHistory : Form
    {
        public static CheckoutHistory instance;
        public CheckoutHistory()
        {
            InitializeComponent();
            instance = this;
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

        private void maxbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minbutton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxbutton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void closebutton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bTFASdaniel_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Thinking Fast and Slow";
                BorrowForm.instance.aut.Text = "Daniel Kahneman";
                BorrowForm.instance.ctg.Text = "Psychology";
            }
            this.Hide();
        }

        private void bPKMpitras_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Pitras Kay Mazameen";
                BorrowForm.instance.aut.Text = "Pitras Bukhari";
                BorrowForm.instance.ctg.Text = "Literature";
            }
            this.Hide();
        }

        private void bWTWWOliz_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "When the World was Ours";
                BorrowForm.instance.aut.Text = "Liz Kessler";
                BorrowForm.instance.ctg.Text = "History";
            }
            this.Hide();
        }

        private void bTKOTHaw_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The Knowledge of the Holy";
                BorrowForm.instance.aut.Text = "AW Tozer";
                BorrowForm.instance.ctg.Text = "General Knowledge";
            }
            this.Hide();
        }

        private void bCCsteve_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Code Complete";
                BorrowForm.instance.aut.Text = "Steve Council";
                BorrowForm.instance.ctg.Text = "Comp. Science";
            }
            this.Hide();
        }
    }
}
