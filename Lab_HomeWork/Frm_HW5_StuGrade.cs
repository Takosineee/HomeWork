using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Lab_HomeWork
{
    public partial class Frm_HW5_StuGrade : Form
    {

        public Frm_HW5_StuGrade()
        {
            InitializeComponent();
            InitializelsvShowGrade(lsvShowGrade);//視窗一開始就要出現所以在 Form 的建構式中呼叫它
            InitializelsvShowStatistics(lsvShowStatistics);
        }


        //因為需要儲存不同的資料型態的資料，建立一個以此結構為資料型態的泛用集合
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Add(txtName.Text, txtChinese.Text, txtEnglish.Text, txtMath.Text);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please enter a smaller value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnAddrndItem1_Click(object sender, EventArgs e)
        {
            RandomItem(1);
        }

        private void btnAddrndItem20_Click(object sender, EventArgs e)
        {
            RandomItem(20);
        } 
        Random rnd = new Random(); 
        public void RandomItem(int rndnum)
        {  
            for (int i = 0; i < rndnum; i++)//不管有沒有用到i都可以用迴圈
            {
                double N = lsvShowGrade.Items.Count + 1;
                double Chi = rnd.Next(1, 100);
                double Eng = rnd.Next(1, 100);
                double M = rnd.Next(1, 100);
                double sum = Chi + Eng + M;
                double avg = sum / 3.0;
                double[] arr0 = { Chi, Eng, M };//比大小陣列
                double btm = arr0.Min();
                double top = arr0.Max();
                if (btm == Chi)
                {
                    if (top == Eng)
                    {
                        string[] arr = new string[8] { N.ToString(), Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "Chinese: " + btm.ToString(), "English: " + top.ToString() };
                        ListViewItem item = new ListViewItem(arr);
                        lsvShowGrade.Items.Add(item);
                    }
                    else if (top == M)
                    {
                        string[] arr = new string[8] { N.ToString(), Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "Chinese: " + btm.ToString(), "Math: " + top.ToString() };
                        ListViewItem item = new ListViewItem(arr);
                        lsvShowGrade.Items.Add(item);
                    }
                }
                else if (btm == Eng)
                {
                    if (top == M)
                    {
                        string[] arr = new string[8] { N.ToString(), Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "English: " + btm.ToString(), "Math: " + top.ToString() };
                        ListViewItem item = new ListViewItem(arr);
                        lsvShowGrade.Items.Add(item);
                    }
                    else if (top == Chi)
                    {
                        string[] arr = new string[8] { N.ToString(), Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "English: " + btm.ToString(), "Chinese: " + top.ToString() };
                        ListViewItem item = new ListViewItem(arr);
                        lsvShowGrade.Items.Add(item);
                    }
                }
                else if (btm == M)
                {
                    if (top == Chi)
                    {
                        string[] arr = new string[8] { N.ToString(), Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "Math: " + btm.ToString(), "Chinese: " + top.ToString() };
                        ListViewItem item = new ListViewItem(arr);
                        lsvShowGrade.Items.Add(item);
                    }
                    else if ( top == Eng)
                    {
                        string[] arr = new string[8] { N.ToString(), Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "Math: " + btm.ToString(), "English: " + top.ToString() };
                        ListViewItem item = new ListViewItem(arr);
                        lsvShowGrade.Items.Add(item);
                    }
                }   
            }
            ////Random rnd = new Random();
            //int N =lsvShowGrade.Items.Count+1;
            //int Chi = rnd.Next(1,100);
            //int Eng = rnd.Next(1,100);
            //int Math = rnd.Next(1, 100);
            //int sum = Chi + Eng + Math;
            //int avg = sum / 3;
            //int[] arr0 = { Chi, Eng, Math };//比大小陣列
            //int btm = arr0.Min();
            //int top = arr0.Max();
            //string []arr = new string[8]{ N.ToString(), Chi.ToString(), Eng.ToString(), Math.ToString(), sum.ToString(), avg.ToString(), btm.ToString(), top.ToString()};
            //return arr;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsTitle(lsvShowStatistics);
            Statistics(lsvShowGrade);
            ShowStat(lsvShowStatistics);
            btnClose();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            lsvShowGrade.Items.Clear();
            lsvShowStatistics.Clear();
            btnOpen();
        }
        //需要的統計值:

        public double sumChi = 0;
        public double sumEng = 0;
        public double sumMath = 0;
        public double avgChi;
        public double avgEng;
        public double avgMath;
        public double btmChi;
        public double btmEng;
        public double btmMath;
        public double topChi;
        public double topEng;
        public double topMath;
        public void Statistics(System.Windows.Forms.ListView lsv)
        {
            
            //從listview中取值(須從string 轉型)建立各科的分數集合
            List<double> chi = new List<double>();
            List<double> eng = new List<double>();
            List<double> math = new List<double>();

            foreach (ListViewItem item in lsv.Items)
            {
                //Item:第幾筆,Subitems:該筆資料第幾個欄位[索引]           
                //國文分數:Subitems[1]
                sumChi += double.Parse(item.SubItems[1].Text);
                avgChi = sumChi / Convert.ToDouble(lsv.Items.Count);
                chi.Add(double.Parse(item.SubItems[1].Text));
                btmChi = chi.Min();
                topChi = chi.Max();

                //英文分數:Subitems[2]
                sumEng += double.Parse(item.SubItems[2].Text);
                avgEng = sumEng / Convert.ToDouble(lsv.Items.Count);
                eng.Add(double.Parse(item.SubItems[2].Text));
                btmEng = eng.Min();
                topEng = eng.Max();


                //數學分數:Subitems[3]
                sumMath += double.Parse(item.SubItems[3].Text);
                avgMath = sumMath / Convert.ToDouble(lsv.Items.Count);
                math.Add(double.Parse(item.SubItems[3].Text));
                btmMath = math.Min();
                topMath = math.Max();
            }
        }
        public void ShowStat(System.Windows.Forms.ListView lsv)
        {   
            string[] statSum = { "Sum", sumChi.ToString(), sumEng.ToString(), sumMath.ToString() };
            string[] statAvg = { "Average", Math.Round(avgChi, 1).ToString(), Math.Round(avgEng, 1).ToString(), Math.Round(avgMath, 1).ToString() };
            string[] statBtm = { "Bottom", btmChi.ToString(), btmEng.ToString(), btmMath.ToString() };
            string[] statTop = { "Top", topChi.ToString(), topEng.ToString(), topMath.ToString() };
            ListViewItem sum = new ListViewItem(statSum);
            ListViewItem avg = new ListViewItem(statAvg);
            ListViewItem btm = new ListViewItem(statBtm);
            ListViewItem top = new ListViewItem(statTop);
            lsv.Items.Add(sum);
            lsv.Items.Add(avg);
            lsv.Items.Add(btm);
            lsv.Items.Add(top);
        }
        public void btnClose()
        {
            btnAdd.Enabled = false;
            btnAddrndItem1.Enabled = false;
            btnAddrndItem20.Enabled = false;
            btnStatistics.Enabled = false;
        }
        public void btnOpen()
        {
            btnAdd.Enabled = true;
            btnAddrndItem1.Enabled = true;
            btnAddrndItem20.Enabled = true;
            btnStatistics.Enabled = true;
        }
        public void InitializelsvShowGrade(System.Windows.Forms.ListView lsv)//初始化(設定屬性)listview
        {
            lsv.View = View.Details;
            lsv.GridLines = true;
            lsv.LabelEdit = false;
            lsv.Width = 600;

            lsv.Columns.Add("Name", 70, textAlign: HorizontalAlignment.Center);
            lsv.Columns.Add("Chinese", 70, textAlign: HorizontalAlignment.Center);
            lsv.Columns.Add("English", 70, textAlign: HorizontalAlignment.Center);
            lsv.Columns.Add("Math", 70, textAlign: HorizontalAlignment.Center);
            lsv.Columns.Add("Sum", 70, textAlign: HorizontalAlignment.Center);
            lsv.Columns.Add("Average", 70, textAlign: HorizontalAlignment.Center);
            lsv.Columns.Add("Bottom", 90, textAlign: HorizontalAlignment.Center);
            lsv.Columns.Add("Top", 90, textAlign: HorizontalAlignment.Center);
        }
        public void InitializelsvShowStatistics(System.Windows.Forms.ListView lsv)//初始化(設定屬性)listview
        {
            lsv.View = View.Details;
            lsv.GridLines = true;
            lsv.LabelEdit = false;
            lsv.Width = 600;
            lsv.Height = 160;
        }
        
        public static void StatisticsTitle(System.Windows.Forms.ListView lsv)
        {
            lsv.Columns.Add("", 65);
            lsv.Columns.Add("Chinese", 65, textAlign: HorizontalAlignment.Center);
            lsv.Columns.Add("English", 65, textAlign: HorizontalAlignment.Center);
            lsv.Columns.Add("Math", 65, textAlign: HorizontalAlignment.Center);
        }
        public void Add(string txtN, string txtC, string txtE, string txtM) 
        {
            List<StuGrade> lsSGL = new List<StuGrade>();

            //驗證是否是數字
            if (!(txtN == ""))//!(沒有文字)=有文字
            {
                if (Regex.IsMatch(txtC, "^([0-9]{1,})$") && Regex.IsMatch(txtE, "^([0-9]{1,})$") && Regex.IsMatch(txtM, "^([0-9]{1,})$"))//正規表達式:限制>=0的正整數
                {
                    //結構實作
                    StuGrade sgl = new StuGrade(txtN, double.Parse(txtC), double.Parse(txtE), double.Parse(txtM));
                    lsSGL.Add(sgl);

                    //用迴圈取出一筆筆資料?
                    foreach (StuGrade i in lsSGL)
                    {
                        //建立需要比較數值的陣列
                        double[] arr0 = { i.Chinese, i.English, i.Math };
                        double minValue = arr0.Min();//陣列最小值
                        double maxValue = arr0.Max();//陣列最大值

                        //全部轉成string，建立可以儲存1個item的陣列
                        string N = i.Name;
                        double Chi = i.Chinese;
                        double Eng = i.English;
                        double M = i.Math;
                        double sum = i.Chinese + i.English + i.Math;
                        double avg = sum / 3.0;
                        double btm = minValue;
                        double top = maxValue;

                        //比大小
                        if (btm == Chi)
                        {
                            if (top == Eng)
                            {
                                string[] arr = new string[8] { N, Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "Chinese: " + btm.ToString(), "English: " + top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                            else if (top == M)
                            {
                                string[] arr = new string[8] { N, Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "Chinese: " + btm.ToString(), "Math: " + top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                        }
                        else if (btm == Eng)
                        {
                            if (top == M)
                            {
                                string[] arr = new string[8] { N.ToString(), Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "English: " + btm.ToString(), "Math: " + top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                            else if (top == Chi)
                            {
                                string[] arr = new string[8] { N.ToString(), Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "English: " + btm.ToString(), "Chinese: " + top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                        }
                        else if (btm == M)
                        {
                            if (top == Chi)
                            {
                                string[] arr = new string[8] { N.ToString(), Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "Math: " + btm.ToString(), "Chinese: " + top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                            else if (top == Eng)
                            {
                                string[] arr = new string[8] { N.ToString(), Chi.ToString(), Eng.ToString(), M.ToString(), sum.ToString(), Math.Round(avg, 1).ToString(), "Math: " + btm.ToString(), "English: " + top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                        }
                    }
                }
                else//非數值
                {
                    MessageBox.Show("Allow only integer values.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else//沒有文字
            {
                MessageBox.Show("Please enter your name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
 }

