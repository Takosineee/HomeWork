using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M12 : Form
    {
        public Frm_M12()
        {
            InitializeComponent();
        }
        int num = 0;//初始值放在方法外面
        private void btnCount_Click(object sender, EventArgs e)
        {
           //num = num + 1;
            num += 1;
            labCount.Text = "Count:" + num;
        }
        //前置遞增:num先計算再asign給result
        private void btnCount2_Click(object sender, EventArgs e)
        {
            int result = ++num;                                                 
            //num+=1, 
            //result=num                                                                                     
            MessageBox.Show(num + ",result:" + result);

        }
        //後置遞增:先asign給result,再計算num
        private void btnCount3_Click(object sender, EventArgs e)
        {
            int result = num++;
            MessageBox.Show(num + ",result:" + result);
            //result=num ,
            //num+=1 
        }
        //前置vs後置:只有result值有差異，num都是相同的，
        //因此有無asign其他變數是結果有差異的關鍵。

        private void btnLocalVar_Click(object sender, EventArgs e)
        {
            int a = 100;

            if (true)
            {
                int x = 200;
                a += x;
                ClassVarA += a;
            }   
        }
        int ClassVarA = 300;
        //static vs instance變數的差異:
        //instance需要建立實體。
        StaticLab sl = new StaticLab();
        private void btnInstanceCount_Click(object sender, EventArgs e)
        {
            //StaticLab sl = new StaticLab();在方法內，只會建立一次實體就消失
            sl.Instance += 1;
            labInstanceCount.Text = "Count:" + sl.Instance;
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            StaticLab.Static += 1;
            labStaticCount.Text = "Count:" +StaticLab.Static;
        }

        private void btnOpenFrm_08_Click(object sender, EventArgs e)
        {
            Frm_08 open08 = new Frm_08();
            open08.Show();
        }

       
    }
}
