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
    public partial class Favorites : Form
    {
        public static Favorites Instance;
        public Favorites()
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Visible == true)
            {
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Visible == true)
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox7.Visible = true;
                pictureBox2.Visible = false;
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Visible == true)
            {
                pictureBox2.Visible = true;
                pictureBox7.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox9.Visible = true;
                pictureBox1.Visible = false;
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox9.Visible = false;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Visible == true)
            {
                pictureBox10.Visible = true;
                pictureBox6.Visible = false;
            }
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Visible == true)
            {
                pictureBox6.Visible = true;
                pictureBox10.Visible = false;
            }
        }
    }
}
