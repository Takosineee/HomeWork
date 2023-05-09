using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_Form
{
    public partial class Frm_M16 : Form
    {
        public Frm_M16()
        {
            InitializeComponent();
        }
        //參數傳遞(實值型別):

        private void btnPassbyValueType_Click(object sender, EventArgs e)
        {
            int a = 100;//設a=100，
            PassbyValueType(a);//即使下一步有參數值，
            MessageBox.Show(a.ToString());//變數a不變。
        }
        static void PassbyValueType(int age/*參數的型態:數值*/)
        {
            age = 50;
        }
        //參數傳遞(參考型別):
        private void btnPassbyReferenceType_Click(object sender, EventArgs e)
        {
            Member mb = new Member();
            mb.Name = "John";
            mb.Age = 50;//即便這裡設mb.Age=50，
            PassbyReferenceType(mb);//但參數於下一個流程傳入，因此結果改為22
            MessageBox.Show("Name:" + mb.Name + "Age:" + mb.Age);
        }
        void PassbyReferenceType(Member member /*參數的型態:類別下的實體(會員)*/)
        //參考型參數:方法定義參數後，若改變參數值，會改變
        {
            member.Age = 22;
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            int a = 100;
            Ref(ref a);
            MessageBox.Show(a.ToString());
        }
        void Ref(ref int Age)//透過參數把a傳進來(=100)，再透過這個參數把資料傳回給a(=50)
        {
            Age = 50;
        }
        //return:只能回傳一個值，但有可能要回傳很多個值
        private void btnOutPut_Click(object sender, EventArgs e)
        {
            int a=0;//想在方法裡面透過參數把這個值傳送給a，
                          //必須要先定義一個變數a，才能接到output 參數
            OutPut(out a);
            MessageBox.Show(a.ToString());
        }
        void OutPut(out int age)//out:透過output 參數把資料傳到外面
        {
            age = 20;
        }

        private void btnParams_Click(object sender, EventArgs e)
        {
         string resultChi = TotalScore("國文", 100, 50, 50,100);
            MessageBox.Show(resultChi);
         string resultMath = TotalScore("數學", 100, 50, 50, 100);
            MessageBox.Show(resultMath);
        }
        string TotalScore(string Subject, params int[] Scores)
         {
            int total = 0;
            for (int i=0;i<Scores.Length; i++)
            {
                total += Scores[i];
            }
            return Subject + "的總成績為" + total + "分";
         }
    }
}
