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
    public partial class Historical : Form
    {
        public static Historical Instance;
        public Historical()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Historical_Load(object sender, EventArgs e)
        {

        }

        private void navLabel_Click(object sender, EventArgs e)
        {
            HomePage form=new HomePage();
            form.ShowDialog();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Blood and Sugar";
                BorrowForm.instance.aut.Text = "Laura";
                BorrowForm.instance.ctg.Text = "History";
            }
            this.Hide();
        }

        private void Borrowbutton_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.Show();
            this.Hide();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Return Return = new Return();
            Return.Show();
            this.Hide();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve();
            reserve.Show();
            this.Hide();
        }

        private void FineButton_Click(object sender, EventArgs e)
        {
            Fine fine = new Fine();
            fine.Show();
            this.Hide();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {

            CheckoutHistory history = new CheckoutHistory();
            history.Show();
            this.Hide();
        }

        private void FavsButton_Click(object sender, EventArgs e)
        {
            Favorites favs = new Favorites();
            favs.Show();
            this.Hide();
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            request.Show();
            this.Hide();
        }

        private void bTHOTAWsusan_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The History of the Ancient World";
                BorrowForm.instance.aut.Text = "Susan Wise Bauer";
                BorrowForm.instance.ctg.Text = "History";
            }
            this.Hide();
        }

        private void bTHBnehemiah_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The Historical Books";
                BorrowForm.instance.aut.Text = "Nehemiah";
                BorrowForm.instance.ctg.Text = "History";
            }
            this.Hide();
        }

        private void bATLWCSanthony_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "All the Light We Cannot See";
                BorrowForm.instance.aut.Text = "Anthony Doerr";
                BorrowForm.instance.ctg.Text = "History";
            }
            this.Hide();
        }

        private void bTCTAEamin_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The Chrusades Through Arab Eyes";
                BorrowForm.instance.aut.Text = "Amin Maalouf";
                BorrowForm.instance.ctg.Text = "History";
            }
            this.Hide();
        }

        private void bWTWWOliz_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "When the World Was Ours";
                BorrowForm.instance.aut.Text = "Liz Kessler";
                BorrowForm.instance.ctg.Text = "History";
            }
            this.Hide();
        }

        private void bTLMwilliam_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The Last Mughal";
                BorrowForm.instance.aut.Text = "William Darlymple";
                BorrowForm.instance.ctg.Text = "History";
            }
            this.Hide();
        }

        private void bGron_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Grant";
                BorrowForm.instance.aut.Text = "Ron Chernow";
                BorrowForm.instance.ctg.Text = "History";
            }
            this.Hide();
        }

        private void bTKkristin_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The Nightingale";
                BorrowForm.instance.aut.Text = "Kristin Hannah";
                BorrowForm.instance.ctg.Text = "History";
            }
            this.Hide();
        }
    }
}
