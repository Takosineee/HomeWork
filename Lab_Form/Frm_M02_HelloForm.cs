using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_Form
{
    public partial class Frm_M02_HelloForm : Form
    {
        public Frm_M02_HelloForm()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = Name1.Text;
            string engname = EngName1.Text;
            string sex = Sex1.Text;
            string zod = Zod1.Text;
            MessageBox.Show("Hello,我是" + name + ","
                + "\n\r" + "我的英文名字是" + engname + ","
                + "\n\r" + "我的性別是" + sex + ","
                + "\n\r" + "我的星座是" + zod + "。");

        }
        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string name2 = Name1.Text;
            string engname2 = EngName1.Text;
            string sex2 = Sex1.Text;
            string zod2 = Zod1.Text;
            MessageBox.Show("Hi,我是" + name2 + ","
                + "\n\r" + "我的英文名字是" + engname2 + ","
                + "\n\r" + "我的性別是" + sex2 + ","
                + "\n\r" + "我的星座是" + zod2 + "。");


        }
    }
}

