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
    public partial class Frm_M30_泛用集合 : Form
    {
        public Frm_M30_泛用集合()
        {
            InitializeComponent();
        }
        List<Product> lsPro=new List<Product>();
        public void ShowProducts()//-->方法:把顯示儲存的產品加入清單中
        {
            labShow.Text = "產品\n";
            decimal totalPrice = 0;
            //for (int i = 0; i < lsPro.Count; i++)
            //for迴圈:索引恆小於集合內元素數量，所以需要判斷式
            //    //[i]:集合的索引?
            //    //count :內建於組件中的方法，取得結構中儲存資料的的數量
            //{
            //    labShow.Text += $"名稱:{lsPro[i].Name},"
            //        + $"單價:{lsPro[i].Price:c0}\n";//c:貨幣;0:小數點
            //    totalPrice += lsPro[i].Price;
            //}
            //labShow.Text += $"\n------------\n數量:{lsPro.Count}"
            //    + $"\n單價加總:{totalPrice:c0}\n單價平均:{totalPrice / lsPro.Count:C0}";
            foreach (Product item in lsPro) 
            //foreach迴圈:本就設定取完集合內所有元素
            {
                
                labShow.Text += $"名稱:{item.Name},"//item:全部產品的集合
                    + $"單價:{item.Price:c0}\n";//c:貨幣;0:小數點
                totalPrice += item.Price;
            }
            labShow.Text += $"\n------------\n數量:{lsPro.Count}"
                + $"\n單價加總:{totalPrice:c0}\n單價平均:{totalPrice / lsPro.Count:C0}";//一筆一筆加入


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = txtProductName.Text;
            pro.Price = decimal.Parse(txtProductPrice.Text);

            lsPro.Add(pro);
            ShowProducts();
        }

    }
}
