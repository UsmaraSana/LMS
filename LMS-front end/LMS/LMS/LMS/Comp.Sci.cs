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
    public partial class Comp : Form
    {
        public static Comp Instance;
        public Comp()
        {
            InitializeComponent();
            Instance = this; 
        }

        private void Comp_Load(object sender, EventArgs e)
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

        private void bCSAFVBjohn_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Computer Science for Visual Basic";
                BorrowForm.instance.aut.Text = "John Smiley";
                BorrowForm.instance.ctg.Text = "Comp. Science";
            }
            this.Hide();
        }

        private void bTCSBtom_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "The Computer Science Book";
                BorrowForm.instance.aut.Text = "Tom Johnson";
                BorrowForm.instance.ctg.Text = "Comp. Science";
            }
            this.Hide();
        }

        private void bRpeter_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Robotics";
                BorrowForm.instance.aut.Text = "Peter Mckinnon";
                BorrowForm.instance.ctg.Text = "Comp. Science";
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

        private void bCCSharley_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Cambridge Computer Science";
                BorrowForm.instance.aut.Text = "Harley";
                BorrowForm.instance.ctg.Text = "Comp. Science";
            }
            this.Hide();
        }

        private void bBPwalker_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Beginners Programming";
                BorrowForm.instance.aut.Text = "Walker Wang";
                BorrowForm.instance.ctg.Text = "Comp. Science";
            }
            this.Hide();
        }

        private void bCPdsmalik_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "C++ Programming";
                BorrowForm.instance.aut.Text = "DS Malik";
                BorrowForm.instance.ctg.Text = "Comp. Science";
            }
            this.Hide();
        }

        private void bMCStyler_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Modern Computer Science";
                BorrowForm.instance.aut.Text = "Tyler Cordan";
                BorrowForm.instance.ctg.Text = "Comp. Science";
            }
            this.Hide();
        }

        private void bCS12william_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            if (borrowForm.Visible == true)
            {
                BorrowForm.instance.ttl.Text = "Computer Science 12";
                BorrowForm.instance.aut.Text = "William James";
                BorrowForm.instance.ctg.Text = "Comp. Science";
            }
            this.Hide();
        }
    }
}
