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
    public partial class GK : Form
    {
        public static GK Instance;
        public GK()
        {
            InitializeComponent();
            Instance = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void navLabel_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
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

        private void namePanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void bTKOFds_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The Knowledge of Love";
                BorrowForm.instance.aut.Text = "DS Williams";
                BorrowForm.instance.ctg.Text = "General Knowledge";
            }
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Beginning of Infinity";
                BorrowForm.instance.aut.Text = "David Deutsch";
                BorrowForm.instance.ctg.Text = "General Knowledge";
            }
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Zer-e-Haqiqi Rawayaat";
                BorrowForm.instance.aut.Text = "Molana Tariq";
                BorrowForm.instance.ctg.Text = "General Knowledge";
            }
            this.Hide();
        }

        private void bEOGKali_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Encyclopedia of General Knowledge";
                BorrowForm.instance.aut.Text = "Ali Khan";
                BorrowForm.instance.ctg.Text = "General Knowledge";
            }
            this.Hide();
        }

        private void bCGKumar_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Comprehensive General Knowledge";
                BorrowForm.instance.aut.Text = "Umar Kazmi";
                BorrowForm.instance.ctg.Text = "General Knowledge";
            }
            this.Hide();
        }

        private void bCOGKkartik_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Capsule of General Knowledge";
                BorrowForm.instance.aut.Text = "Kartik";
                BorrowForm.instance.ctg.Text = "General Knowledge";
            }
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Kon Kia Ha";
                BorrowForm.instance.aut.Text = "Shahid Muhammad";
                BorrowForm.instance.ctg.Text = "General Knowledge";
            }
            this.Hide();
        }
    }
}
