using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M26_Array : Form
    {
        public Frm_M26_Array()
        {
            InitializeComponent();
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int[3];//[元素個數.陣列長度]
            arr[0] = 1;//[元素索引值]
            arr[1] = 2;
            arr[2] = 3;
            //-->建立陣列後，指定元素值
            //arr[3] = 4;元素的索引值從0開始，超出陣列長度
            //MessageBox.Show(arr[0].ToString());
            string result = "";
            int[] arr2 = new int[3] { 1, 2, 3 };
             int[] arr3 = { 1, 2, 3 };//簡寫
             //-->建立陣列時，指定元素值
            for (int i = 0; i<arr3.Length; i++)//.Length:取元素個數
            {
                result += $"{arr3[i]}\n";
            }
            MessageBox.Show(result);
        }
        //多維陣列
        private void btnArray2_Click(object sender, EventArgs e)
        {

        }

        private void btnSystemArray_Click(object sender, EventArgs e)
        {
            Member [] mems = new Member[2];//Member 陣列，類別當型態用
            mems[0] = new Member();//instance:須建立實體
            mems[0].Name = "John";
            mems[0].Age = 50;
            mems[1] = new Member();

        }

        private void btnReturnArray_Click(object sender, EventArgs e)
        {
            int[] myArr = CreateArray(20);//帶參數
            MessageBox.Show(myArr[0].ToString());
        }
        int[] CreateArray(int Len) 
        {
            int[] arr = new int[Len];
            for (int i = 0; i < arr.Length; i++/*可略*/) 
            {
                arr[i] = i + 1;
                //arr[i]=i++;
            }
            return arr;
        }
        string result = "";
        private void btnforeach_Click(object sender, EventArgs e)
        {
            int[] myArr = CreateArray(20);
            foreach (int item in myArr)
            {
                result += item + "\n";
            }
            MessageBox.Show(result);
        }

    }
}
