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
    public partial class Psychological : Form
    {
        public static Psychological Instance;
        public Psychological()
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
            form.Show();
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

        private void label8_Click(object sender, EventArgs e)
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

        private void bDSOPmichael_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Dark Secrest of Psychology";
                BorrowForm.instance.aut.Text = "Michael Davis";
                BorrowForm.instance.ctg.Text = "Psychology";
            }
            this.Hide();
        }

        private void bTPBfreud_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The Psychology Book";
                BorrowForm.instance.aut.Text = "Freud";
                BorrowForm.instance.ctg.Text = "Psychology";
            }
            this.Hide();
        }

        private void bBOjprdan_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Beyond Order";
                BorrowForm.instance.aut.Text = "Jordan B Peterson";
                BorrowForm.instance.ctg.Text = "Psychology";
            }
            this.Hide();
        }

        private void bPOHBrori_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Psychology of Human Behavior";
                BorrowForm.instance.aut.Text = "Rori Dasani";
                BorrowForm.instance.ctg.Text = "Psychology";
            }
            this.Hide();
        }

        private void bYANSSdavid_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "You Are Not So Smart";
                BorrowForm.instance.aut.Text = "David Mcraney";
                BorrowForm.instance.ctg.Text = "Psychology";
            }
            this.Hide();
        }

        private void bPFBmax_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Psychology for Beginners";
                BorrowForm.instance.aut.Text = "Max Krone";
                BorrowForm.instance.ctg.Text = "Psychology";
            }
            this.Hide();
        }

        private void bTPOYSMjoseph_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The Power of Your Subconscious Mind";
                BorrowForm.instance.aut.Text = "Joseph Murphy";
                BorrowForm.instance.ctg.Text = "Psychology";
            }
            this.Hide();
        }

        private void bMSFMviktor_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Man's Search For Meaning";
                BorrowForm.instance.aut.Text = "Victor Frankl";
                BorrowForm.instance.ctg.Text = "Psychology";
            }
            this.Hide();
        }
    }
}
