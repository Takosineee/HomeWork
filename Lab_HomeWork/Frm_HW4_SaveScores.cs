using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab_HomeWork
{
    public partial class Frm_HW4_SaveScores : Form
    {

        public Frm_HW4_SaveScores()
        {
            InitializeComponent();
        }


        List<Scores> lsSco = new List<Scores>();
        //必須使用各種不同的資料型態時，將他們集合在一個結構下，以此做為新的資料型態
        //讓Scores 結構作為新的資料型態使用
        private void btnSave_Click(object sender, EventArgs e)
        {
            double num;
            bool isNum1 = double.TryParse(txtChiScore.Text, out num);
            bool isNum2 = double.TryParse(txtEngScore.Text, out num);
            bool isNum3 = double.TryParse(txtMathScore.Text, out num);
            if (isNum1 && isNum2 && isNum3)
            {
                Scores sco = new Scores(txtName.Text, double.Parse(txtChiScore.Text), double.Parse(txtEngScore.Text), double.Parse(txtMathScore.Text));
                lsSco.Add(sco);
            }
            else
            {
                MessageBox.Show("Allow only nemerical values.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiScore.Focus();
            }
        }
        private void btnShowSavedData_Click(object sender, EventArgs e)
        {
            foreach (Scores item in lsSco)
            {
                labScores.Text = $"Name:{item.Name}\nChinese:{item.Chinese}" +
                    $"\nEnglish:{item.English}\nMath:{item.Math}";
            }
        }

    
        private void btnShowTopAndBtm_Click(object sender, EventArgs e)
        {
            

            //foreach取出集合內科目分數值 
            foreach (Scores item in lsSco)
            {
                double[] arr ={ item.Chinese, item.English, item.Math};
                //定義一個成績排序的陣列(item:泛用集合中的一個元素/一筆資料?)

                Array.Sort(arr);//低至高
                if (Array.IndexOf(arr, item.Chinese) == 2)//若c最高
                {
                    if (Array.IndexOf(arr, item.English) == 0)//e最低
                    {
                        labTopAndBtm.Text = $"Top: Chinese {arr[2]}\nBottom: English {arr[0]}";//取該索引i之值:arr[i]
                    }
                    else if (Array.IndexOf(arr, item.Math) == 0)//m最低
                    {
                        labTopAndBtm.Text = $"Top: Chinese {arr[2]}\nBottom: Math {arr[0]}";
                    }
                }
                else if (Array.IndexOf(arr, item.English) == 2)
                {
                    if (Array.IndexOf(arr, item.Chinese) == 0)
                    {
                        labTopAndBtm.Text = $"Top: English {arr[2]}\nBottom: Chinese {arr[0]}";
                    }
                    else if (Array.IndexOf(arr, item.Math) == 0)
                    {
                        labTopAndBtm.Text = $"Top: English {arr[2]} \nBottom: Math {arr[0]}";
                    }
                }
                else if (Array.IndexOf(arr, item.Math) == 2)
                {
                    if (Array.IndexOf(arr, item.Chinese) == 0)
                    {
                        labTopAndBtm.Text = $"Top: Math {arr[2]} \nBottom: Chinese {arr[0]}";
                    }
                    else if (Array.IndexOf(arr, item.English) == 0)
                    {
                        labTopAndBtm.Text = $"Top: Math {arr[2]} \nBottom: English {arr[0]}";
                    }
                }
                else 
                {
                    labTopAndBtm.Text = $"Top: Chinese {arr[2]} \nBottom: Chinese {arr[0]}";
                }



                //大小
                //bool CE = item.Chinese > item.English;
                //bool CM = item.Chinese > item.Math;
                //bool EC = item.English > item.Chinese;
                //bool EM = item.English > item.Math;
                //bool MC = item.Math > item.Chinese;
                //bool ME = item.Math > item.English;
                ////大中小
                //bool CEM = CE && EM;
                //bool CME = CM && ME;
                //bool EMC = EM && MC;
                //bool ECM = EC && CM;
                //bool MEC = ME && EC;
                //bool MCE = MC && CE;
                ////等於
                //bool CeqE = item.Chinese == item.English;
                //bool CeqM = item.Chinese == item.Math;
                //bool MeqE = item.Math == item.English;

                ////最高:中;最低:數
                //if (CEM|| MeqE&&CM)
                //{
                //    labTopAndBtm.Text = $"Top: Chinese {item.Chinese}\nBottom: Math {item.Math}";
                //}
                ////最高:中;最低:英
                //else if (CME)
                //{
                //    labTopAndBtm.Text = $"Top: Chinese {item.Chinese}\nBottom: English {item.English}";
                //}
                ////最高:英;最低:中
                //else if (EMC)
                //{
                //    labTopAndBtm.Text = $"Top: English {item.English}\nBottom: Chinese {item.Chinese}";
                //}
                ////最高:英;最低:數
                //else if (ECM|| CeqM&&EM)
                //{
                //    labTopAndBtm.Text = $"Top: English {item.English}\nBottom: Math {item.Math}";
                //}
                //else if (MEC|| CeqE&&MC)
                //{
                //    labTopAndBtm.Text = $"Top: Math {item.Math}\nBottom: Chinese {item.Chinese}";
                //}
                //else if(MCE) 
                //{
                //    labTopAndBtm.Text = $"Top: Math {item.Math}\nBottom: English {item.English}";
                //}  
                //else 
                //{
                //    labTopAndBtm.Text = $"Top: Math {item.Math}\nBottom: Math {item.Math}";
                //}
            }
        }
    }
}
//double Top = item.Chinese > item.English ? ((item.Chinese > item.Math) ? item.Chinese : item.Math) : ((item.English > item.Math) ? item.English : item.Math);
//double Btm = item.Chinese < item.English ? ((item.Chinese < item.Math) ? item.Chinese : item.Math) : ((item.English < item.Math) ? item.English : item.Math);

