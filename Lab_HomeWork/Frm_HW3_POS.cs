using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_HomeWork
{
    public partial class Frm_HW3_POS : Form
    {
        public Frm_HW3_POS()
        {
            InitializeComponent();
        }

        private void btnSwissRoll_Click(object sender, EventArgs e)
        {
            HW3_Num.Sr += 1;
            HW3_Price.Sr += 50;
            HW3_Show.Sr = $"Swiss roll x {HW3_Num.Sr}, NT${HW3_Price.Sr}\n";
            //在這個click方法中只有Sr的值
            labShowOrder.Text = HW3_Show.Sr + HW3_Show.NYc + HW3_Show.P + HW3_Show.Mc;
            //清單中預設show出全部的品項
            
            TotalPrice();
            //call: Totalprice()方法
        }

        private void btnNYCheeseCake_Click(object sender, EventArgs e)
        {
            HW3_Num.NYc += 1;
            HW3_Price.NYc += 75;
            HW3_Show.NYc= $"NY CheeseCake x {HW3_Num.NYc} , NT$ {HW3_Price.NYc}\n";
            labShowOrder.Text = HW3_Show.Sr + HW3_Show.NYc + HW3_Show.P + HW3_Show.Mc;
            TotalPrice();
        }
        private void btnPuffs_Click(object sender, EventArgs e)
        {
            HW3_Num.P += 1;
            HW3_Price.P += 60;
            HW3_Show.P = $"Puffs x {HW3_Num.P} , NT$ {HW3_Price.P}\n";
            labShowOrder.Text = HW3_Show.Sr + HW3_Show.NYc + HW3_Show.P + HW3_Show.Mc;
            TotalPrice();
        }
        private void btnMilleCrepes_Click(object sender, EventArgs e)
        {

            HW3_Num.Mc += 1;
            HW3_Price.Mc += 100;
            HW3_Show.Mc = $"Mille crepe x {HW3_Num.Mc} , NT$ {HW3_Price.Mc}\n";
            labShowOrder.Text = HW3_Show.Sr + HW3_Show.NYc + HW3_Show.P + HW3_Show.Mc;
            TotalPrice();

        }

        public int TotalPrice()
        {
            HW3_TotalPrice.TotalPrice = HW3_Price.Sr + HW3_Price.NYc + HW3_Price.P + HW3_Price.Mc;
            labShowTotalPrice.Text = $"NT$ {HW3_TotalPrice.TotalPrice}";

            return HW3_TotalPrice.TotalPrice;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //數值和字串都要歸零!!!!
            labShowOrder.Text = string.Empty;
            labShowTotalPrice.Text = string.Empty;
            labShowOrder.Text = "No order";
            labShowTotalPrice.Text = "NT$0";
            HW3_TotalPrice.TotalPrice 
                = HW3_Price.Sr = HW3_Price.NYc = HW3_Price.P = HW3_Price.Mc
                =HW3_Num.Sr = HW3_Num.NYc =  HW3_Num.P = HW3_Num.Mc
                =0;
            HW3_Show.Sr = HW3_Show.NYc = HW3_Show.P = HW3_Show.Mc
            = string.Empty;
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            if (HW3_TotalPrice.TotalPrice == 0)
            {
                MessageBox.Show("No order!", "Check out",MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            else 
            {
                MessageBox.Show("Total Price: NT$"+ HW3_TotalPrice.TotalPrice , "Check out");
            }
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            if (HW3_TotalPrice.TotalPrice == 0)
            {
                MessageBox.Show("No order!", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Total Price: NT$" + HW3_TotalPrice.TotalPrice
                    +"\nSale Price: NT$"+HW3_TotalPrice.TotalPrice * 0.9, "Check out");
            }
        }
    }
}
