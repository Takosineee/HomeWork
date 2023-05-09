using Lab_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_HomeWork
{
    public partial class Frm_HW2_report : Form
    {   
        public Frm_HW2_report()
        {
            InitializeComponent();
        }
       
        public void Report()
        {
            labShowLoan.Text = HW2_Report.Loan.ToString();//物件.屬性=內容值
            labShowTerm.Text=HW2_Report.Term.ToString();
            labShowRate.Text = HW2_Report.Rate.ToString();
            labShowPMT.Text= HW2_Report.PMT.ToString();
            labShowPayment.Text = HW2_Report.TotalPayment.ToString();

        }
    
    }
     
}
