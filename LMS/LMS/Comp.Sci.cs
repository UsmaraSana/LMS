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
    }
}
