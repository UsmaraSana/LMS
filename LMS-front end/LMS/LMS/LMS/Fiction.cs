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
    public partial class Fiction : Form
    {
        public static Fiction Instance;
        public Fiction()
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

        private void namePanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void bRMmario_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Remember Me";
                BorrowForm.instance.aut.Text = "Mario Escobar";
                BorrowForm.instance.ctg.Text = "Fiction";
            }
            this.Hide();
        }

        private void bMOGmelanie_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Memories of Glass";
                BorrowForm.instance.aut.Text = "Melanie Dobson";
                BorrowForm.instance.ctg.Text = "Fiction";
            }
            this.Hide();
        }

        private void bHPjk_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Harry Potter";
                BorrowForm.instance.aut.Text = "JK Rowling";
                BorrowForm.instance.ctg.Text = "Fiction";
            }
            this.Hide();
        }

        private void bWMBBfrances_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "We Must Be Brave";
                BorrowForm.instance.aut.Text = "Frances Liardet";
                BorrowForm.instance.ctg.Text = "Fiction";
            }
            this.Hide();
        }

        private void bWITSaisha_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Written in the Stars";
                BorrowForm.instance.aut.Text = "Aisha Saeed";
                BorrowForm.instance.ctg.Text = "Fiction";
            }
            this.Hide();
        }

        private void bWTLGsara_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Where the Light Goes";
                BorrowForm.instance.aut.Text = "Sara Barnard";
                BorrowForm.instance.ctg.Text = "Fiction";
            }
            this.Hide();
        }

        private void bTSAOSbrigid_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The Sun and Other Stars";
                BorrowForm.instance.aut.Text = "Brigid Pasulka";
                BorrowForm.instance.ctg.Text = "Fiction";
            }
            this.Hide();
        }

        private void bNLMGcatelyn_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Never Let Me Go";
                BorrowForm.instance.aut.Text = "Catelyn";
                BorrowForm.instance.ctg.Text = "Fiction";
            }
            this.Hide();
        }

        private void bTBOLFlisa_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The Book of Lost Friends";
                BorrowForm.instance.aut.Text = "Lisa Wingate";
                BorrowForm.instance.ctg.Text = "Fiction";
            }
            this.Hide();
        }
    }
}
