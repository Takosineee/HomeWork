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
    public partial class Frm_M34 : Form
    {
        public Frm_M34()
        {
            InitializeComponent();
        }

        private void btnStreamReader_Click(object sender, EventArgs e)
        {
            //相對路徑:會預設檔案在該專案所在位置，若在其他資料夾中需要打出資料夾名稱
            //StreamReader sr= new StreamReader("../../../SR.txt", Encoding.UTF8);
            
            //絕對路徑:
            StreamReader sr = new StreamReader(" C:\\Users\\User\\Desktop\\C#\\SR.txt", Encoding.UTF8);
            
            txtStreamReader.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btnStreamWriter_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("..\\..\\..\\SW.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(txtStreamReader.Text);
            sw.Close();
            fs.Close();
        }

        private void btnDeBug_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";
            for (i = 0; i < 10; i++) 
            {
                result += i++;
            }
            MessageBox.Show(result);
        }
        void Method(string result)
        {
            MessageBox.Show(result);
        }
    }
}
