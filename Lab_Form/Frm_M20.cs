using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M20 : Form
    {
        public Frm_M20()
        {
            InitializeComponent();
        }
        bool flag = true;//不可放在方法中，否則每次執行都會歸零
        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btnReverse.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnReverse.BackColor = Color.SeaGreen;
            }
            flag = !flag;
        }
        //三元運算式()?1:0: 括號內為true，執行1; false執行0
        private void btnTenary_Click(object sender, EventArgs e)
        {
            btnReverse.BackColor = (flag) ? Color.CornflowerBlue : Color.SeaGreen;
            flag=!flag;
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            //90~100:S
            //80~89:A
            //70~79:B
            //60~69:C
            //<60:D
            int score = int.Parse(txtScore.Text);

            int s;
            bool isNum=int.TryParse(txtScore.Text, out s);
            if (isNum)
            {
                if (score >= 90 && score <= 100)
                {
                    labGrade.Text = "Band: S";
                }
                else if (score >= 80 && score <= 89)
               //上面的判斷式不符合才會到這一步，所以不用設上限
                {
                    labGrade.Text = "Band: A";
                }
                else if (score >= 70 && score <= 79)
                {   
                    labGrade.Text = "Band: B";
                }
                else if (score >= 60 && score <= 69)
                {
                    labGrade.Text = "Band: C";
                }
                else
                {
                    labGrade.Text = "Band: D";
                }
            }
            else 
            {
                MessageBox.Show($"Number only!");
                txtScore.Clear();
                txtScore.Focus();
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("你想爽領上億年薪嗎?", "這不是詐騙",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //用resultru接住messagebox的結果
            switch(result)//帶入result，也就是要判斷的物件
            {
                case DialogResult.Yes :
                    MessageBox.Show("Yes");
                    break;
                case DialogResult.No :
                    MessageBox.Show("No");
                    break;
                default:
                    //其他所有情況，所以包含:X，cancel
                    MessageBox.Show("default");
                    break;
            }
        }
        //前測試:有可能都不符合條件就一次都不會執行
        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";
            while (i < 10) //條件判斷式
            {
                result += $"{i++}\n";//先輸出(把值丟給result)，再加1
                //i++;
                //++i;
                //沒有指派給別的變數，結果相同
                //MessageBox.Show(result); -->每次運算結果都會跑出一個messagebox
            }
            MessageBox.Show(result);
        }
        //後測試:至少執行一次迴圈敘述，進入迴圈後運算結果
        //，依照結果決定是否繼續執行迴圈敘述or結束
        private void btnDo_Click(object sender, EventArgs e)
        {
            int i= 0;
            //int i=10;結果為10
            string result = "";
            do
            {//do 迴圈{}中為「迴圈敘述」
                result += $"{i++}\n";
            //i++
            }while (i < 10) ;//「條件運算式」
            MessageBox.Show(result);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i<10; i ++) //用分號隔開
            {
                result += $"{i}\n";
            }
            MessageBox.Show(result);
        }
        //break
        private void btnForPractice_Click(object sender, EventArgs e)
        {
            string result = "";
            //for (int p = 2, q = 50, r = 100; p + q < r; ++p) //不能用分號
            //{
            //    result += $"p={p}, q={q}, r={r}\n";
            //}
            
            for (int i = 0, j = 100, x = 50; ; i += 3, x--)
            { 
            if(!Condition(i,x,j))
                    break;
                result += $"i:{i},j:{j},x:{x}\n";
            }

            bool Condition(int i, int x, int j)
            {
                return i + x < j;
            }
            MessageBox.Show(result);
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)//Control:用類別當作型態來使用
            {
                item.BackColor = Color.DarkSeaGreen;
                item.ForeColor = Color.Cornsilk;
                item.Top -=10;//Top:與最上方的距離
                item.Left -=15;//Left:與最左方的距離
            }

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {    //if(item.GetType()!=typeof(button))
                //continue;
                if (!(item is Button))
                    continue;
                item.BackColor = Color.DarkSeaGreen;
                item.ForeColor = Color.Cornsilk;
                item.Top -= 10;//Top:與最上方的距離
                item.Left -= 15;//Left:與最左方的距離
            }
        }
    }
}
