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
    public partial class Updata : Form
    {
        public static string path;
        public static string info;
        public Updata()
        {
            InitializeComponent();
            //path = @"C:\Users\ntt\Pictures\Camera Roll\IMG_4014.JPG";
            //pictureBox1.Image = Image.FromFile(path);
        }

        private void Updata_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mySubmitBtn_Click(object sender, EventArgs e)
        {
            info = "学号：" + tbxId.Text + "\r\n";
            info += "姓名：" + tbxName.Text + "\r\n";
            foreach(Control control in gbxSex.Controls)
            {
                if((control as RadioButton).Checked)
                {
                    info += "性别：" + (control as RadioButton).Text;
                }
            }
            info += "\r\n爱好：";
            foreach (Control control in gbxFavor.Controls)
            {
                if ((control as CheckBox).Checked)
                {
                    info += (control as CheckBox).Text + "";
                }
            }
            info += "\r\n出生日期：" + dateTimePicker1.Text;
            info += "\r\n专业：" + comboBox1.Text;
            welcome.browserForm = new Browser();
            welcome.browserForm.Show();
            this.Opacity = 0;
            

        }
        private void gbxFavor_Enter(object sender, EventArgs e)
        {

        }

        private void myOpenPictureBtn_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = @"E:\个人";
            this.openFileDialog1.Filter = "bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif|jepg文件(*.jpg)|*.jpg";
            this.openFileDialog1.FilterIndex = 3;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "选择学生照片";
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                path = this.openFileDialog1.FileName;
            }
            pictureBox1.Image = Image.FromFile(path);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("2012年度优秀团员");
            listBox1.Items.Add("2012年度一等奖学金");
            listBox1.Items.Insert(2, "2012年度校运动会1000米游泳冠军");
            listBox1.SelectedIndex = 1;
            string msg = string.Format("已添加奖惩记录{0}条",listBox1.Items.Count);
            MessageBox.Show(msg, "提示");

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLableNowTime.Text = string.Format("现在时间：{0}", DateTime.Now.ToLongTimeString());
            toolStripProgressBar1.PerformStep();
            if(toolStripProgressBar1.Value==toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
            }
        }

        private void toolStripStatusLableNowTime_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
