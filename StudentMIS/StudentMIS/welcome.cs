using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMIS
{
    public partial class welcome : Form
    {
        public static Login loginForm;
        public static Updata updataForm;
        public static Browser browserForm;
        public welcome()
        {
            InitializeComponent();
            loginForm = new Login();
            updataForm = new Updata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            loginForm.Show();
            this.Hide();

        }
    }
}
