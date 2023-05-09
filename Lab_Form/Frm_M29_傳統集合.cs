using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M29_傳統集合 : Form
    {
        
        public Frm_M29_傳統集合()
        {
            InitializeComponent();
        }
        public void ShowProducts()//-->方法:把顯示儲存的產品加入清單中
        {
            for (int i = 0; i < lsPro.Count; i++)
                //[i]:集合的索引?
               //count :內建於組件中的方法，取得結構中儲存資料的的數量
            {
                labShow.Text += $"名稱:{((Product)lsPro[i]).Name},"
                    + $"單價:{((Product)lsPro[i]).Price}\n";
            }
        }
        ArrayList lsPro = new ArrayList();//
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = txtProductName.Text;
            pro.Price = decimal.Parse(txtProductPrice.Text);

            lsPro.Add(pro);

            //for (int i=0;i<lsPro.Count;i++)
            //{
            //    labShow.Text += $"名稱:{((Product)lsPro[i]).Name},"
            //        + $"單價:{((Product)lsPro[i]).Price}\n";
            //}-->寫成方法:較好維護
            ShowProducts();
            //call方法

        }
    }
}
