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
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(StudentMIS.Updata.path);
            tbxStudentInfo.Text = StudentMIS.Updata.info;
            
        }

        private void Browser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcome.updataForm.Opacity = 1;
            welcome.updataForm.Show();
            this.Close();

        }
    }
}
