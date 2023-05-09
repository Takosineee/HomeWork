using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_HomeWork
{


    public partial class Frm_HW6_StuGradeList : Form
    {

        public Frm_HW6_StuGradeList()
        {
            InitializeComponent();
            frm.InitializelsvShowGrade(lsvShowGrade);
            frm.InitializelsvShowStatistics(lsvShowStatistics);
            btnClear.Enabled = false;
            btnStatistics.Enabled = false;
            btnRemoveAt.Enabled = false;
            btnSearch.Enabled = false;
        }

        Frm_HW5_StuGrade frm = new Frm_HW5_StuGrade();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                StuGraAdd();
            }
            catch (OverflowException)
            {
                //MessageBox.Show("Please enter a smaller value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnRemoveAt.Enabled = true;
            btnStatistics.Enabled = true;
            btnClear.Enabled = true;
            btnSearch.Enabled = true;

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                StuGraInsert();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please enter a smaller value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnRemoveAt.Enabled = true;
            btnStatistics.Enabled = true;
            btnClear.Enabled = true;
            btnSearch.Enabled = true;
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            lsvShowGrade.Items.RemoveAt(0);
            if (lsvShowGrade.Items.Count == 0)
            {
                btnStatistics.Enabled = false;
                btnRemoveAt.Enabled = false;
                btnSearch.Enabled = false;
                btnClear.Enabled = false;
            }
            //如果移除到清單中沒有東西時就關閉除了加入和插入之外的控制項
        }
        //public double sumChi = 0;
        //public double sumEng = 0;
        //public double sumMath = 0;
        //public double avgChi;
        //public double avgEng;
        //public double avgMath;
        //public double btmChi;
        //public double btmEng;
        //public double btmMath;
        //public double topChi;
        //public double topEng;
        //public double topMath;
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Frm_HW5_StuGrade.StatisticsTitle(lsvShowStatistics);
            frm.Statistics(lsvShowGrade);
            frm.ShowStat(lsvShowStatistics);
            if (lsvShowGrade.Items.Count == 0) //如果沒有資料不能統計
            {
                btnStatistics.Enabled = false;
                btnRemoveAt.Enabled = false;
            }
           //按下統計之後關閉除了清除之外的控制項
            btnAdd.Enabled = false;
            btnInsert.Enabled = false;
            btnRemoveAt.Enabled = false;
            btnStatistics.Enabled = false;
            btnSearch.Enabled = false;
            btnClear.Enabled = true;          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsvShowGrade.Items.Clear();
            lsvShowStatistics.Clear();

            btnAdd.Enabled = true;
            btnInsert.Enabled = true;

            btnStatistics.Enabled = false;
            btnRemoveAt.Enabled = false;
            btnClear.Enabled = false;
            btnSearch.Enabled=false;
            //按下清除之後只開啟加入和插入控制項
        }
        public void StuGraAdd()
        {
            List<StuGradeList> lsSGL = new List<StuGradeList>();
            if (txtName.Text != "")//!=:不相等
            {
                if (Regex.IsMatch(txtChinese.Text, "^([0-9]{1,})$")&& Regex.IsMatch(txtEnglish.Text, "^([0-9]{1,})$") && Regex.IsMatch(txtMath.Text, "^([0-9]{1,})$"))//正規表達式:限制>=0的正整數
                {
                    StuGradeList sgl;
                    sgl.Name = txtName.Text;
                    sgl.Chinese = double.Parse(txtChinese.Text);
                    sgl.English = double.Parse(txtEnglish.Text);
                    sgl.Math = double.Parse(txtMath.Text);
                    sgl.Sum = sgl.Chinese + sgl.English + sgl.Math;
                    sgl.Avg = sgl.Sum/3.0;
                    double[] arr0 = { sgl.Chinese, sgl.English, sgl.Math };
                    double minValue = arr0.Min();//陣列最小值
                    double maxValue = arr0.Max();//陣列最大值
                    sgl.Btm = minValue;
                    sgl.Top = maxValue;
                    lsSGL.Add(sgl);
                    foreach (StuGradeList i in lsSGL)
                    {
                        if (i.Btm == i.Chinese)
                        {
                            if (i.Top == i.English)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "Chinese: " + i.Btm.ToString(), "English: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                            else if (i.Top == i.Math)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "Chinese: " + i.Btm.ToString(), "Math: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                        }
                        else if (i.Btm == i.English)
                        {
                            if (i.Top == i.Math)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "English: " + i.Btm.ToString(), "Math: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                            else if (i.Top == i.Chinese)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "English: " + i.Btm.ToString(), "Chinese: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                        }
                        else if (i.Btm == i.Math)
                        {
                            if (i.Top == i.Chinese)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "Math: " + i.Btm.ToString(), "Chinese: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                            else if (i.Top == i.English)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "Math: " + i.Btm.ToString(), "English: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Add(item);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter your name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void StuGraInsert()
        {
            if (txtName.Text != "")
            {
                List<StuGradeList> lsSGL = new List<StuGradeList>();
                if (Regex.IsMatch(txtChinese.Text, "^([0-9]{1,})$") && Regex.IsMatch(txtEnglish.Text, "^([0-9]{1,})$") && Regex.IsMatch(txtMath.Text, "^([0-9]{1,})$"))//正規表達式:限制>=0的正整數
                {
                    StuGradeList sgl;
                    sgl.Name = txtName.Text;
                    sgl.Chinese = double.Parse(txtChinese.Text);
                    sgl.English = double.Parse(txtEnglish.Text);
                    sgl.Math = double.Parse(txtMath.Text);
                    sgl.Sum = sgl.Chinese + sgl.English + sgl.Math;
                    sgl.Avg = sgl.Sum / 3;
                    double[] arr0 = { sgl.Chinese, sgl.English, sgl.Math };
                    double minValue = arr0.Min();//陣列最小值
                    double maxValue = arr0.Max();//陣列最大值
                    sgl.Btm = minValue;
                    sgl.Top = maxValue;
                    lsSGL.Add(sgl);
                    foreach (StuGradeList i in lsSGL)
                    {
                        if (i.Btm == i.Chinese)
                        {
                            if (i.Top == i.English)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "Chinese: " + i.Btm.ToString(), "English: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Insert(0, item);
                            }
                            else if (i.Top == i.Math)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "Chinese: " + i.Btm.ToString(), "Math: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Insert(0, item);
                            }
                        }
                        else if (i.Btm == i.English)
                        {
                            if (i.Top == i.Math)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "English: " + i.Btm.ToString(), "Math: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Insert(0, item);
                            }
                            else if (i.Top == i.Chinese)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "English: " + i.Btm.ToString(), "Chinese: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Insert(0, item);
                            }
                        }
                        else if (i.Btm == i.Math)
                        {
                            if (i.Top == i.Chinese)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "Math: " + i.Btm.ToString(), "Chinese: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Insert(0, item);
                            }
                            else if (i.Top == i.English)
                            {
                                string[] arr = new string[8] { i.Name, i.Chinese.ToString(), i.English.ToString(), i.Math.ToString(), i.Sum.ToString(), Math.Round(i.Avg, 1).ToString(), "Math: " + i.Btm.ToString(), "English: " + i.Top.ToString() };
                                ListViewItem item = new ListViewItem(arr);
                                lsvShowGrade.Items.Insert(0, item);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter your name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
           
        public void StuGraChiSearch()
        {
            if (Regex.IsMatch(txtMin.Text, "^([0-9]{1,})$") && Regex.IsMatch(txtMax.Text, "^([0-9]{1,})$"))
            {
                if (lsvShowGrade.Items.Count != 0)
                {
                    foreach (ListViewItem item in lsvShowGrade.Items)
                    {
                        int minSearch = int.Parse(txtMin.Text);
                        int maxSearch = int.Parse(txtMax.Text);
                        int chi = int.Parse(item.SubItems[1].Text);
                        if (chi < minSearch | chi > maxSearch)
                        {
                            lsvShowGrade.Items.Remove(item);
                        }
                    }
                }              
            }
            else
            {
                MessageBox.Show("Please enter a numerical value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            StuGraChiSearch();
            btnAdd.Enabled = true;
            btnInsert.Enabled = true;
            btnClear.Enabled = true;
            btnSearch.Enabled = true;
            btnStatistics.Enabled = true;
            if (lsvShowGrade.Items.Count == 0)
            {
                btnStatistics.Enabled = false;
                btnRemoveAt.Enabled = false;
                btnSearch.Enabled=false;
                btnClear.Enabled=false;
            }
        }
    }
}

















        //int btm;
        //int top; 
        //string btmsubject;
        //string topsubject;
        //public void CompareResult(int ChiGra,int EngGra,int MathGra,out string btmsubject, out string topsubject)
        //{

        //    if (btm == ChiGra)
        //    {
        //        if (top == EngGra)
        //        {
        //            btmsubject = "Chinese: ";
        //            topsubject = "English: ";
        //        }
        //        else if (top == MathGra)
        //        {
        //            btmsubject = "Chinese: ";
        //            topsubject = "Math: ";
        //        }
        //    }
        //    else if (btm == EngGra)
        //    {
        //        if (top == MathGra)
        //        {
        //            btmsubject = "English: ";
        //            topsubject = "Math: ";

        //        }
        //        else if (top == ChiGra)
        //        {
        //            btmsubject = "English: ";
        //            topsubject = "Chinese: ";
        //        }
        //    }
        //    else if (btm == MathGra)
        //    {
        //        if (top == ChiGra)
        //        {
        //            btmsubject = "Math: ";
        //            topsubject = "Chinese: ";
        //        }
        //        else if (top == EngGra)
        //        {
        //            btmsubject = "Math: ";
        //            topsubject = "English: ";
        //        }
    
    

