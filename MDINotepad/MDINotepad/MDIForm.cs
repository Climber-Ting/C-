using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notepad;

namespace MDINotepad
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {

        }

        private void 窗口WToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTxt MDIChid = new frmTxt();
            MDIChid.MdiParent = this;
            MDIChid.Show();
        }

        private void 垂直平铺VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 层叠CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void 水平平铺HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 全部关闭LToolStripMenuItem_Click(object sender, EventArgs e)
        {
           foreach(Form childForm in MdiChildren)
           {
               childForm.Close();
           }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.Text = textBox1.Text;
        }
    }
}
