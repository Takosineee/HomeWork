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
    public partial class Frm_M19 : Form
    {
        public Frm_M19()
        {
            InitializeComponent();
        }
        //struct:儲存【相關】但【資料型態不同】的資料
        //，集合在一個struct下，為一種資料型態(如class.enum...)
        //像是會員資料、產品資料有string、int...
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Employee emp;定義結構
            //emp.Name = txtEmployeeName.Text;
            //emp.Age = int.Parse(txtEmployeeAge.Text);
            //labShow.Text+="\n"+"Name:"+emp.Name+", Age:"+emp.Age;

            //Employee emp2 = new Employee();
            //emp2.Name=txtEmployeeName.Text;
            //emp2.Age=int.Parse(txtEmployeeAge.Text);
            //labShow.Text += "\n" + "Name:" + emp2.Name + ", Age:" + emp2.Age;

            //定義欄位
            int age;
            bool isNum=int.TryParse(txtEmployeeAge.Text, out age);
            //TryParse:判斷是否為數字，因此傳出bool值
            //out:只會傳出值，所以定義age 欄位不需要帶入數字               
            if (isNum)
            {
                Employee emp3 = new Employee(txtEmployeeName.Text,
                                               int.Parse(txtEmployeeAge.Text));/*建立實體:new+建構函示*/
                //帶入Utility.cs中定義在結構下的方法，儲存資料
                //結構具現化:此稱為 結構函式(剛剛定義的參數);
                labShow.Text += $"\nName:{emp3.Name} , Age:{emp3.Age}";
            }
            else 
            {
                MessageBox.Show($"請輸入數字，蛤哪");
                txtEmployeeAge.Clear();
                txtEmployeeAge.Focus();
            }


            
            
        }
    }
}
