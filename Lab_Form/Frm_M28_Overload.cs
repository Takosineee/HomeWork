using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M28_Overload : Form
    {
        public Frm_M28_Overload()
        {
            InitializeComponent();
        }
        //多載or同名方法(overload):在相同的方法下，參數要用到不同數值型態或個數時使用。
        void Swap( ref int A, ref int B)//強制改變a=100,b=200
        {
            int T = A;
            A = B;
            B = T;
        }

        void Swap(ref string A, ref string B) 
        {
            string T = A;
            A = B;
            B = T;
        }
        private void btnForint_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            MessageBox.Show($"a={a},b={b}");
            
            Swap(ref a, ref b);//如果沒有ref，變數a,b不會受參數定義影響
            //兩個參數都要設定ref
            MessageBox.Show($"a={a},b={b}");
        }
        private void btnForstring_Click(object sender, EventArgs e)
        {
            string a="100" , b ="200";
            MessageBox.Show($"a={a},b={b}");

            Swap(ref  a,ref b);
            MessageBox.Show($"a={a},b={b}");
        }
        //泛型(Generic):，通常我們在參數只有型態不同時不會使用多載，
        //而是使用「泛型」，似於資料型態的參數
        /*泛用方法:使用在方法上的泛型。
         不用考慮使用者輸入的是甚麼資料型別，不需要Boxing(轉型為物件object)*/
        //案用方法和其他方法相同，但(參數)--><內容自定義>，
        //呼叫時，<>中的資料型態自訂，帶入何種型態的參數，<Tt>就代表該型態
        void GenericSwap<P>(ref P A, ref P B)
        {
            P T = A;
            A = B;
            B = T;
        }
        void GenericSwap<P, Q>(ref P A, ref P B, Q Y, out Q output)
            //P,Q代表兩種不同的參數型態
        {
            P T = A;
            A = B;
            B = T;

            output = Y;
        }

        private void btnGenericMethod_Click(object sender, EventArgs e)
        {
            int a=100, b=200;
            GenericSwap<int>(ref a, ref b);
            MessageBox.Show($"a={a}, b={b}");
            string strA = "abc", strB = "def";
            GenericSwap/*<string>可以省略，*/(ref strA, ref strB);
            MessageBox.Show($"a={strA}, b={strB}");
        }
    }
}
