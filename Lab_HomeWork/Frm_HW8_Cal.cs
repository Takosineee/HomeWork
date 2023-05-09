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
    public partial class Frm_HW8_Cal : Form
    {
        public Frm_HW8_Cal()
        {
            InitializeComponent();
        }
        double Num1;//先宣告變數
        double Num2;
        double num;
        bool isNum1;
        bool isNum2;

            private void btnPlus_Click(object sender, EventArgs e)
        {
            isNum1 = double.TryParse(txtNum1.Text, out num);//再asign內容值
            isNum2 = double.TryParse(txtNum2.Text, out num);
            //必須兩個txtbox都輸入數值型
            if (isNum1 && isNum2)
            {
                Num1 = double.Parse(txtNum1.Text);
                Num2 = double.Parse(txtNum2.Text);
                double Answer = Num1 + Num2;
                Math.Round(Answer, 4);
                txtAnswer.Text = Math.Round(Answer, 4).ToString();
            }
            else
            {
                MessageBox.Show($"Accept only numerical values.", "Warning"
                 , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum1.Focus();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            bool isNum1= double.TryParse(txtNum1.Text,out num);
            bool isNum2 = double.TryParse(txtNum2.Text, out num);
            switch (isNum1&&isNum2)
             {
                case true:
                Num1 = double.Parse(txtNum1.Text);
                Num2 = double.Parse(txtNum2.Text);
                double Answer = Num1 - Num2;

                    Math.Round(Answer, 4);
                    txtAnswer.Text = Math.Round(Answer, 4).ToString();
                    break;
                default:
                    MessageBox.Show($"Accept only numerical values.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNum1.Clear();
                    txtNum2.Clear();
                    txtNum1.Focus();
                    break;
            }
        }   
        private void btnTimes_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNum1.Text, out num);
            bool isNum2 = double.TryParse(txtNum2.Text, out num);
            switch (isNum1 && isNum2)
            {
                case true:
                     Num1 = double.Parse(txtNum1.Text);
                     Num2 = double.Parse(txtNum2.Text);
                    double Answer = Num1 * Num2;
                    Math.Round(Answer, 4);
                    txtAnswer.Text = Math.Round(Answer, 4).ToString();
                    break;
                default:
                    MessageBox.Show($"Accept only numerical values.", "Warning"
                     , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNum1.Clear();
                    txtNum2.Clear();
                    txtNum1.Focus();
                    break;
            }
        }

        private void btnDividedby_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNum1.Text, out num);
            bool isNum2 = double.TryParse(txtNum2.Text, out num);
            switch (isNum1 && isNum2)
            {
                case true:
                     Num1 = double.Parse(txtNum1.Text);
                     Num2 = double.Parse(txtNum2.Text);
                    double Answer = Num1 / Num2;
                    Math.Round(Answer, 4);
                    txtAnswer.Text = Math.Round(Answer, 4).ToString();
                    break;
                default:
                    MessageBox.Show($"Accept only numerical values.", "Warning"
                     , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNum1.Clear();
                    txtNum2.Clear();
                    txtNum1.Focus();
                    break;
            }
        }
    }
}
