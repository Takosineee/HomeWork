using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Lab_Form;//先新增參考的組件，才能再接著引用

namespace Lab_Console
{

    internal class Program
    { 
        static void Main(string[] args)
        {
         Console.Write("請輸入姓名:");
         string Name = Console.ReadLine();
         Console.WriteLine("Hello C#!" + Name);
         Console.ReadKey();
         MyClass mc = new MyClass();
           //存取修飾詞為public 才能呼叫，因此此處只能呼叫Method04
           {
                mc.Method04();
            }
        }
    }
}
