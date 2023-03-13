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
    public partial class Literature : Form
    {
        public static Literature Instance;

        public Literature()
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

        private void label15_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Dusra Ishq";
                BorrowForm.instance.aut.Text = "Qesar Abbas";
                BorrowForm.instance.ctg.Text = "Literature";
            }
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
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

        private void bRCdaniel_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Robinson Crusoe";
                BorrowForm.instance.aut.Text = "Daniel Defoe";
                BorrowForm.instance.ctg.Text = "Literature";
            }
            this.Hide();
        }

        private void bSAIHumera_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Seher Aik Istiara Ha";
                BorrowForm.instance.aut.Text = "Umera Ahmed";
                BorrowForm.instance.ctg.Text = "Literature";
            }
            this.Hide();
        }

        private void bOHOELandrew_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Oxford History of English Literture";
                BorrowForm.instance.aut.Text = "Andrew Sanders";
                BorrowForm.instance.ctg.Text = "Literature";
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

        private void bMKCkrishan_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Mazameen Krishan Chandar";
                BorrowForm.instance.aut.Text = "Krishan Chandar";
                BorrowForm.instance.ctg.Text = "Literature";
            }
            this.Hide();
        }

        private void bABOELsierra_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "A Background of English Literature";
                BorrowForm.instance.aut.Text = "Sierra";
                BorrowForm.instance.ctg.Text = "Literature";
            }
            this.Hide();
        }

        private void bACTHOELhamad_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "A Companion to History of English literature";
                BorrowForm.instance.aut.Text = "Hamad";
                BorrowForm.instance.ctg.Text = "Literature";
            }
            this.Hide();
        }

        private void bRARshakeeb_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "roshni Ay Roshni";
                BorrowForm.instance.aut.Text = "Shakeeb Jalali";
                BorrowForm.instance.ctg.Text = "Literature";
            }
            this.Hide();
        }
    }
}
