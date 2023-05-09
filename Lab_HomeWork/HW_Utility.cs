using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_HomeWork
{
    public static class HW2_Report//建立一個共用的(utility)類別，在static class中建立新的變數，
                                  //能夠在Frm_HW2_Loan中，讀取txtLoan.Text丟入變數中，
                                  //在Frm_HW2_report中設定內容值。
    {
        public static int Loan;
        public static int Term;
        public static int Rate;
        public static int PMT;
        public static int TotalPayment;
    }
    public static class HW3_TotalPrice
    {
        public static int TotalPrice;
    }
    public static class HW3_Num
    {
        public static int Sr;
        public static int NYc;
        public static int P;
        public static int Mc;
    }
    public static class HW3_Price
    {
        public static int Sr;
        public static int NYc;
        public static int P;
        public static int Mc;
    }
    public static class HW3_Show
    {
        public static string Sr;
        public static string NYc;
        public static string P;
        public static string Mc;
    }
    public struct Scores
    {
        public string Name;
        public double Chinese;
        public double English;
        public double Math;
        public Scores(string name, double chi, double eng, double math)
        {
            Name = name;
            Chinese = chi;
            English = eng;
            Math = math;
        }
    }
    public struct StuGrade
    {
        public string Name;
        public double Chinese;
        public double English;
        public double Math;
       
        public StuGrade(string name, double chi, double eng, double math)
        {
            Name = name;
            Chinese = chi;
            English = eng;
            Math = math;
            
        }
    }
    
    public struct StuGradeList
    {
        public string Name;
        public double Chinese;
        public double English;
        public double Math;
        public double Sum;
        public double Avg;
        public double Btm;
        public double Top;       
    }
    
   
}
