using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_HomeWork
{
    public partial class Frm_HW7_Method : Form
    {
        public Frm_HW7_Method()
        {
            InitializeComponent();
        }
        private void btnEvenorOdd_Click(object sender, EventArgs e)
        {
            MethodEO(arr7);
        }
        private void btnCountEONum_Click(object sender, EventArgs e)
        {
            MethodCountEO(arr7);
        }

        int[] arr7 = { 3, 26, 5, 15, 466, 8, 67, 777, 88, 345 };
        string[] arr7_str = { "Jessica", "起司cake", "Cindy", "Julie", "Jane", "Hi", "dark", "gameofthrones" };
        int[,] arr7_2D = new int[10, 10];
        private void btnMaxandMin_Click(object sender, EventArgs e)
        {
            labResults.Text = $"The integer array 'arr7{{3, 26, 5, 15, 466, 8,  67, 777, 88, 345}}' has: \na MAX. value of '{arr7.Max()}'and\na MIN. value of '{arr7.Min()}'.";

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            labResults.Text = $"The integer array 'arr7{{3, 26, 5, 15, 466, 8,  67, 777, 88, 345}}' has: \nthe SUM of elements of '{arr7.Sum()}'.";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            labResults.Text = $"The integer array 'arr7{{3, 26, 5, 15, 466, 8,  67, 777, 88, 345}}' has: \na MAX. value of '{arr7.Max()}.";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            labResults.Text = $"The integer array 'arr7 {{3, 26, 5, 15, 466, 8,  67, 777, 88, 345}}' has: \na MIN. value of '{arr7.Min()}'.";
        }

        private void btnLongestName_Click(object sender, EventArgs e)
        {
            MethodstrMaxLength(arr7_str);
        }
        private void btnCountCcs_Click(object sender, EventArgs e)
        {
            MethodstrFindChar(arr7_str, "c");
        }

        private void btns1c0_Click(object sender, EventArgs e)
        {
            //i=0,9&j=0,9:1
            Method2DArr(1, 0);

        }

        private void btns0c1_Click(object sender, EventArgs e)
        {
            //i=0,9&j=0,9:0
            Method2DArr(0, 1);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            int eveni = 1;
            int oddi = 0;
            Method2DArrSwap(ref eveni ,ref oddi);

        }
        private void btnSwap_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 200;
            labResults.Text = $"Before: a={a}, b={b}\n";
            Swap(ref a, ref b);
            labResults.Text += $"After: a={a}, b={b}";
        }

        public void MethodEO(int[] arr)
        {
            if (Regex.IsMatch(txtEvenorOdd.Text, "^([0-9]{1,}[.][0-9]*)$") | txtEvenorOdd.Text == "")//正規表達式:驗證該字串是否為有小數點的數字
            {
                MessageBox.Show("Allow only integers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    long num = long.Parse(txtEvenorOdd.Text);
                    if (num % 2 == 0)
                    {
                        labResults.Text = $"{num} is an EVEN number. ";
                    }
                    else
                    {
                        labResults.Text = $"{num} is an ODD number. ";
                    }
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Try a smaller value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public void MethodCountEO(int[] arr)
        {
            int evenCount = 0;//要放在迴圈外，否則每次執行迴圈內的程式碼都會歸零     
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    evenCount += 1;
                    labResults.Text = $"The integer array 'arr7{{3, 26, 5, 15, 466, 8,  67, 777, 88, 345}}' contains:\n'{evenCount}' EVEN numbers and\n'{(arr7.Count()) - evenCount}' ODD numbers.";
                }
            }
        }
        List<int> strLength = new List<int>();//要放在外面才會存進迴圈中產生的元素?
        public void MethodstrMaxLength(string[] arr)
        {
            foreach (string item in arr)
            {
                strLength.Add(item.Length);
            }
            foreach (int i in strLength)
            {
                int index = strLength.IndexOf(strLength.Max());
                labResults.Text = $"The string array ' arr7_str ' :\n' Jessica, 起司cake, Cindy, Julie, Jane, Hi, gameofthrones ' \nhas the longest word of '{arr[index]}'.";
            }

        }
        public void MethodstrFindChar(string[] arr, string letter)
        {
            int cCount = 0;
            foreach (string item in arr)
            {
                string lower = item.ToLower();
                lower.IndexOf(letter);
                if (lower.IndexOf(letter) >= 0)
                {
                    cCount += 1;
                    labResults.Text = $"The string array ' arr7_str ' :\n' Jessica, 起司cake, Cindy, Julie, Jane, Hi, gameofthrones ' \nhas '{cCount}' words with letter 'C' or 'c'.";
                }
            }
        }
        public void Method2DArr(int side, int center)
        {      
            labResults.Text = "";
            for (int i=0; i<10; i++ )
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 | i == 9| j == 0 | j == 9)
                    {
                        arr7_2D[i, j] = side;
                    }
                    else 
                    {
                        arr7_2D[i, j] = center;
                    }
                    labResults.Text += $"{arr7_2D[i, j]} ";
                    if (j != 9)
                        continue;
                    labResults.Text += "\n";
                }
            }
        }
        public void Method2DArrSwap( ref int evenindex, ref int oddindex)
        {
            labResults.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j %2==0)
                    {
                        arr7_2D[i, j] = evenindex;
                    }
                    else
                    {
                        arr7_2D[i, j] = oddindex;
                    }
                    labResults.Text += $"{arr7_2D[i, j]} ";
                    if (j != 9)
                        continue;
                    Swap(ref evenindex, ref oddindex);
                    labResults.Text += "\n";
                }
            }
        }
        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
    }
}


