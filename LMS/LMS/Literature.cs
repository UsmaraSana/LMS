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
    }
}
