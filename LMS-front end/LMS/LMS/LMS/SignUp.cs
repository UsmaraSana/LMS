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
    public partial class SignUp : Form
    {
        public static SignUp instance;
        public SignUp()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttoncreateacc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Account created successfully!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            { 
            login form = new login();
            form.Show();
            this.Hide();
            }
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
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

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPhNo_TextChanged(object sender, EventArgs e)
        {
            textBoxPhNo.ForeColor = Color.Black;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            textBoxEmail.ForeColor = Color.Black;
        }
    }
}
