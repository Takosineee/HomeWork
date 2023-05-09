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
    public partial class Frm_08 : Form
    {
        public Frm_08()
        {
            InitializeComponent();
        }

        private void btnRegisterEvent_Click(object sender, EventArgs e)
        {
            this.btnRegisterEvent01.Click += new System.EventHandler(btnRegisterEvent01Click);
            //因為System 已經引用(using)，可以簡寫
            this.btnRegisterEvent02.Click += btnRegisterEvent02Click;
        }
        private void btnRegisterEvent01Click(object sender, EventArgs e) 
        {
            MessageBox.Show("btnRE01");
        }
        private void btnRegisterEvent02Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnRE02");
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            this.btnRegisterEvent01.Click-=new EventHandler(btnRegisterEvent01Click);
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("你想爽領上億年薪嗎?", "這不是詐騙"
               , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
         if (result == DialogResult.Yes) 
           {
                MessageBox.Show("你憑甚麼?");
           }
          else 
           {
                MessageBox.Show("你確定嗎?");
           }
        }

        private void btncallHelloForm_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frm = new Frm_M02_HelloForm();
            DialogResult result = frm.ShowDialog();//強制回應:必須回應HelloForm，結束對話框，才可以執行Frm_08中的表單中其他按鈕

            if (result == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frm = new Frm_M02_HelloForm();
            frm.Show();
        }

        private void btnShowStaticNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StaticLab.Static.ToString());
        }
    }
}
