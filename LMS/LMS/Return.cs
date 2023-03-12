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
    public partial class Return : Form
    {
        public static Return Instance;
        public Return()
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

        private void rCPdsmalik_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to return this book", "Return book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rCPdsmalik.Text= "Returned";
                rCPdsmalik.BackColor= SystemColors.ActiveBorder;
            }
        }

        private void closebutton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rPFBmaxkrone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to return this book", "Return book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rPFBmaxkrone.Text = "Returned";
                rPFBmaxkrone.BackColor = SystemColors.ActiveBorder;
            }
        }

        private void rRpeter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to return this book", "Return book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                rRpeter.Text = "Returned";
                rRpeter.BackColor = SystemColors.ActiveBorder;
            }
        }

        private void rTBOLFlisa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to return this book", "Return book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rTBOLFlisa.Text = "Returned";
                rTBOLFlisa.BackColor = SystemColors.ActiveBorder;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Visible == true)
            {
                pictureBox30.Visible = true;
                pictureBox13.Visible = false;
            }
        }
        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (pictureBox30.Visible == true)
            {
                pictureBox13.Visible = true;
                pictureBox30.Visible = false;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Visible == true)
            {
                pictureBox25.Visible = true;
                pictureBox11.Visible = false;
            }
        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (pictureBox25.Visible == true)
            {
                pictureBox11.Visible = true;
                pictureBox25.Visible = false;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Visible == true)
            {
                pictureBox26.Visible = true;
                pictureBox6.Visible = false;
            }
        }
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (pictureBox26.Visible == true)
            {
                pictureBox6.Visible = true;
                pictureBox26.Visible = false;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Visible == true)
            {
                pictureBox27.Visible = true;
                pictureBox10.Visible = false;
            }
        }
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (pictureBox27.Visible == true)
            {
                pictureBox10.Visible = true;
                pictureBox27.Visible = false;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Visible == true)
            {
                pictureBox31.Visible = true;
                pictureBox17.Visible = false;
            }
        }
        private void pictureBox31_Click(object sender, EventArgs e)
        {
            if (pictureBox31.Visible == true)
            {
                pictureBox17.Visible = true;
                pictureBox31.Visible = false;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (pictureBox19.Visible == true)
            {
                pictureBox35.Visible = true;
                pictureBox19.Visible = false;
            }
        }
        private void pictureBox35_Click(object sender, EventArgs e)
        {
            if (pictureBox35.Visible == true)
            {
                pictureBox19.Visible = true;
                pictureBox35.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox28.Visible = true;
                pictureBox1.Visible = false;
            }
        }
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (pictureBox28.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox28.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Visible == true)
            {
                pictureBox29.Visible = true;
                pictureBox5.Visible = false;
            }
        }
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            if (pictureBox29.Visible == true)
            {
                pictureBox5.Visible = true;
                pictureBox29.Visible = false;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Visible == true)
            {
                pictureBox32.Visible = true;
                pictureBox12.Visible = false;
            }
        }
        private void pictureBox32_Click(object sender, EventArgs e)
        {
            if (pictureBox32.Visible == true)
            {
                pictureBox12.Visible = true;
                pictureBox32.Visible = false;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (pictureBox16.Visible == true)
            {
                pictureBox33.Visible = true;
                pictureBox16.Visible = false;
            }
        }
        private void pictureBox33_Click(object sender, EventArgs e)
        {
            if (pictureBox33.Visible == true)
            {
                pictureBox16.Visible = true;
                pictureBox33.Visible = false;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (pictureBox18.Visible == true)
            {
                pictureBox34.Visible = true;
                pictureBox18.Visible = false;
            }
        }
        private void pictureBox34_Click(object sender, EventArgs e)
        {
            if (pictureBox34.Visible == true)
            {
                pictureBox18.Visible = true;
                pictureBox34.Visible = false;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (pictureBox20.Visible == true)
            {
                pictureBox36.Visible = true;
                pictureBox20.Visible = false;
            }
        }
        private void pictureBox36_Click(object sender, EventArgs e)
        {
            if (pictureBox36.Visible == true)
            {
                pictureBox20.Visible = true;
                pictureBox36.Visible = false;
            }
        }
    }
}
