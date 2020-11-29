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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbxUsr.Text==string.Empty||tbxPwd .Text==string.Empty)
            {
                MessageBox.Show("信息不完整！","提示");
                return;
            }
            if(!tbxUsr.Text.Equals("admin")||!tbxPwd.Text.Equals("admin"))
            {
                MessageBox.Show("用户名或密码不正确！要重新输入吗？", "提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else
            {
                welcome.updataForm.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxUsr.Clear();
            tbxPwd.Clear();

        }
        private void textBox1_Enter(object sender, System.EventArgs e)
        {
            tbxUsr.SelectionStart = 0;
            tbxUsr.SelectionLength = 0;
        }
        private void textBox2_Enter(object sender, System.EventArgs e)
        {
            tbxPwd.SelectionStart = 0;
            tbxPwd.SelectionLength = tbxUsr.SelectionLength;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
     
    }
}
