using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M32 : Form
    {
        public Frm_M32()
        {
            InitializeComponent();
        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder sb1=new StringBuilder();
            sb1.Append("StringBuilder sb1");
            StringBuilder sb2 = sb1;
            MessageBox.Show($"sb1:{sb1},\n sb2:{sb2}");
            sb1.Append("YO");//參考型別:但當asign給其他變數，修改原變數時，
                             //string的變數改變，其他變數不可被修改，因此需要string builder
            MessageBox.Show($"sb1:{sb1},\n sb2:{sb2}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string dir = "C:\\Users\\User\\Desktop\\Form圖片.jpg";
            string dir = @"C:\Users\User\Desktop\Form圖片.jpg";
            string result = Path.GetFileName(dir) + Path.GetFileNameWithoutExtension(dir);
            MessageBox.Show(result);
        }
    }
}
