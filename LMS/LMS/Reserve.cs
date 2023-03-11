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
    public partial class Reserve : Form
    {
        public static Reserve Instance;
        public Reserve()
        {
            InitializeComponent();
            Instance = this;

        }

        private void navLabel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(); 
            homePage.Show();
        }

        private void notify_Click(object sender, EventArgs e)
        {

        }

        private void Reserve_Load(object sender, EventArgs e)
        {
           
        }

        private void request_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            request.Show();
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
    }
}
