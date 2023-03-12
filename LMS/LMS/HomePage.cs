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
    public partial class HomePage : Form
    {
        public static HomePage instance;
        private bool isCollapsed;
        public HomePage()
        {
            InitializeComponent();
            instance = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {

        }

        private void navLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                categoryDropdown.Height += 30;
                if (categoryDropdown.Size == categoryDropdown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                categoryDropdown.Height -= 30;
                if (categoryDropdown.Size == categoryDropdown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void more_Click(object sender, EventArgs e)
        {

        }

        private void moreTrending_Click(object sender, EventArgs e)
        {

        }

        private void historical_Click(object sender, EventArgs e)
        {
            Historical form = new Historical();
            form.Show();
            this.Hide();
        }

        private void literature_Click(object sender, EventArgs e)
        {
            Literature form = new Literature();
            form.Show();
            this.Hide();
        }

        private void compSci_Click(object sender, EventArgs e)
        {
            Comp form = new Comp();
            form.Show();
            this.Hide();
        }

        private void psychological_Click(object sender, EventArgs e)
        {
            Psychological form = new Psychological();
            form.Show();
            this.Hide();
        }

        private void GK_Click(object sender, EventArgs e)
        {
            GK form = new GK();
            form.Show();
            this.Hide();
        }

        private void fiction_Click(object sender, EventArgs e)
        {
            Fiction form = new Fiction();
            form.Show();
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

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bCPdsmalik_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
            this.Hide();
        }
    }
}
