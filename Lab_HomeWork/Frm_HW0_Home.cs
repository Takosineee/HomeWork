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
    public partial class Frm_HW0_Home : Form
    {
        public Frm_HW0_Home()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_HW1_Hello frmHello = new Frm_HW1_Hello();
            frmHello.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmHello);
            frmHello.Show();
        }
        private void btnLoan_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_HW2_Loan frmLoan = new Frm_HW2_Loan();
            frmLoan.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmLoan);
            frmLoan.Show();
        }
        private void btnPOS_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_HW3_POS frmPOS = new Frm_HW3_POS();
            frmPOS.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmPOS);
            frmPOS.Show();
        }
        private void btnSaveScores_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_HW4_SaveScores frmSave = new Frm_HW4_SaveScores();
            frmSave.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmSave);
            frmSave.Show();
        }
        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_HW5_StuGrade frmStuGrade = new Frm_HW5_StuGrade();
            frmStuGrade.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmStuGrade);
            frmStuGrade.Show();
        }
        private void btnStudentGradeList_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_HW6_StuGradeList frmStuList = new Frm_HW6_StuGradeList();
            frmStuList.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmStuList);
            frmStuList.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_HW7_Method frmMethod = new Frm_HW7_Method();
            frmMethod.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmMethod);
            frmMethod.Show();
        }
        private void btnCalculator_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_HW8_Cal frmCal = new Frm_HW8_Cal();
            frmCal.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmCal);
            frmCal.Show();
        }
    }
}
