using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_HomeWork
{
    public partial class Frm_HW1_Hello : Form
    {
        public Frm_HW1_Hello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click_1(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EngName = txtEngName.Text;
            string Sex = txtSex.Text;
            string Zod = txtZod.Text;
            MessageBox.Show("Hello,我是" + Name + ","
                + "\n\r" + "我的英文名字是" + EngName + ","
                + "\n\r" + "我的性別是" + Sex + ","
                + "\n\r" + "我的星座是" + Zod + "。");
        }

        private void btnSayHi_click_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EngName = txtEngName.Text;
            string Sex = txtSex.Text;
            string Zod = txtZod.Text;
            MessageBox.Show("Hi,我是" + Name + ","
                + "\n\r" + "我的英文名字是" + EngName + ","
                + "\n\r" + "我的性別是" + Sex + ","
                + "\n\r" + "我的星座是" + Zod + "。");
        }
    }
}
