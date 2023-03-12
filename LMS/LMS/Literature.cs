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
    }
}
