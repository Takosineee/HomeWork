using Lab_HomeWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_HW2_Loan : Form
    {
        public Frm_HW2_Loan()
        {
            InitializeComponent();
        }
        private void btnPMT_Click(object sender, EventArgs e)
        {
            int PMT = PMTCount();
            MessageBox.Show("月付額:" + PMT);
        }
        private void btnTotalPay_Click(object sender, EventArgs e)
        {
            int TotalPayment = TotalPaymentCount();
            MessageBox.Show("還款總額:" + TotalPayment);
        }
        public static int TotalMoney,DP, TotalYear, RateYear;
      
        public int PMTCount()
        {
            //讀取值: 變數=物件.屬性;eg. string strName=txtName.Text，為了讀取txtbob裡面的值;
            TotalMoney = int.Parse(txtLoan.Text); /*將數字的"string"表示轉換成它的對等的'int'
                                                                                            ; int本身是32位元。*/
            TotalYear = int.Parse(txtTerm.Text);//期限(年
            RateYear = int.Parse(txtRate.Text);//利率:年
            DP = int.Parse(txtDP.Text);//頭期款

            int TotalMonth /*貸款月數*/  = TotalYear * 12; //輸入單位是(年)，要轉換成(月)
            double RateMonth/*月利率*/= RateYear / 12.0 / 100.0;
            double R /*1+月利率*/= 1 + RateMonth;
            int T = TotalMoney - DP;

            /*每月還款額 = 貸款總額×月利率×(1 + 月利率) ^ 貸款月數 /
            //{ [(1 + 月利率)^貸款月數]-1}
            */

            double pmt = T * RateMonth * Math.Pow(R, TotalMonth)
                / (Math.Pow(R, TotalMonth) - 1);//每月還款
            int PMT = Convert.ToInt32(pmt);//強制轉型成整數
            return PMT;
        }
        public int TotalPaymentCount()
        {
            TotalYear = int.Parse(txtTerm.Text);
            int TotalMonth = TotalYear * 12;
            int PMT = PMTCount();
            int TotalPayment = PMT * TotalMonth;
            return TotalPayment;
        }
        
        private void btnReport_Click(object sender, EventArgs e)
        {
            HW2_Report.Loan = int.Parse(txtLoan.Text);//變數=物件.屬性
            HW2_Report.Term = int.Parse(txtTerm.Text);
            HW2_Report.Rate = int.Parse(txtRate.Text);
            HW2_Report.PMT = PMTCount();
            HW2_Report.TotalPayment = TotalPaymentCount();
            Frm_HW2_report reportfrm= new Frm_HW2_report();
            reportfrm.Report();
            reportfrm.ShowDialog();
        }
        
    }
}
