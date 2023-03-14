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
    public partial class Request : Form
    {
        public static Request Instance;
        public Request()
        {
            InitializeComponent();
            Instance = this;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Request_Load(object sender, EventArgs e)
        {

        }

        private void reqButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to request this book", "Request book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reqButton.Text = "Request Sent";
                reqButton.BackColor= SystemColors.ActiveBorder;
            }
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
    }
}
