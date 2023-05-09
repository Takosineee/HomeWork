using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class MyClass
    {
        void Method01()
        {
            MessageBox.Show("Method01");
        }
        private void Method02()//定義"方法"的語法: "存取修飾詞" 傳回值型態 方法名稱(參數)
        {
            MessageBox.Show("Method02");
        }
        internal void Method03()
        {
            MessageBox.Show("Method03");
        }
        public void Method04()
        {
            MessageBox.Show("Method04");
        }
        public void Method05()//巢狀呼叫:方法內再呼叫別的方法
        {
            Method01();
            Method02();
        }
    }
    public class Member//定義"類別"的方法:存取修飾詞 class 類別名稱
    {
        public string Name;
        public int Age;
    }
    public class StaticLab
    {
        public int Instance;
        public static int Static;
    }
    public enum EnumLab
    {
        Admin = 1,
        User = 0,
        Student = 2,
    }
    public struct Employee//建立一個結構
     {
        public string Name;
        public int Age;//;定義結構的型態(要存的是甚麼型態的資料)
                       //，加上public 才可被外部存取，定義時不可指定初值給變數或屬性，除非變數宣告為const或static

        //public string Name { get; set; }
        //public int Age { get; set; }設定屬性
        public Employee(string EmployeeName, int EmployeeAge)
            //【建構方法】:struct(和class)實作時第一個執行的方法，!!和結構同名稱!!
        //建構方法必須根據剛剛所定義的結構型態，設定定義中每個屬性的內容值
        {
            //資料要存在哪裡?
            Name = EmployeeName;//這個參數帶入的資料存在Name這個欄位
            Age = EmployeeAge;
        }
    }

   
    public struct Product//ArrayList:結構
    {
        public string Name;
        public decimal Price;//decimal :精算
    }
   
        
 }
    


