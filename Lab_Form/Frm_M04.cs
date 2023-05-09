using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//引用組件


namespace Lab_Form
{
    public partial class Frm_M04 : Form/*只要partial class 在相同namespace下，
                                                                    都視為同一類別。
                                                                    同類別拆分成不同檔案下去處理 */                                                                 
    {
        public Frm_M04()
        {
            InitializeComponent();
        }

        private void btnOpenHelloForm_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frm = new Frm_M02_HelloForm();
            frm.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            MyFirstMethod();
         }
        void MyFirstMethod() //有參數時才需要帶入()
        {
          MessageBox.Show("This is my first Method.");/*在方法裡面才能執行程式碼
                                                                                               ，在類別中不可直接執行程式碼*/
         }

        private void btnReturnMethod_Click(object sender, EventArgs e)
        {
            string result = BirthYear(20);//呼叫剛剛定義的方法，string result:需要定義變數接住回傳值
            MessageBox.Show(result);
        }
        string BirthYear(int Age)/*希望的動作: 帶入年齡，回傳出生年。
                                                        字串型態 方法名稱自訂(參數型態:整數 參數:自訂義名稱)*/
        {
            int bYear =DateTime.Now.Year- Age;//int計算結果的型態，bYear :定義計算結果的變數名稱
            return "出生年為" + bYear + "年";//return 的回傳值必須與方法定義的型態相同:"string"
        }
        
        

        //建立一個類別，下方的方法
        private void btnMyClass_Click(object sender, EventArgs e)
        {
            MyClass mc=new MyClass();

            //mc.Method01();
            //mc.Method02();
            mc.Method03();
            mc.Method04();
        }
        //封裝: 保護，呼叫包裝後的方法
        private void btnEnc_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method05();
        }
        //partial class: 可以拆分成不同檔案，但仍在同一個類別下處理
        private void btnPartialClass_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method03();
            mc.Method06();

            
            
        }
        
        private void btnMember_Click(object sender, EventArgs e)
        {    /*物件初始化-1:先建立物件，再設定其內容，
              類似於在房子中增添家具*/

            //先建立實體!!
            Member mem1 = new Member(); //Member: 類別; mem1:自訂義為變項名稱= new:透過new 建立該"類別的'實體'"
            mem1.Name = "Jonh";//將Jonh 丟給實體的變數
            mem1.Age = 40;
            MessageBox.Show("Name:" + mem1.Name + 
                "Age:" + mem1.Age);

            Member mem2 = new Member()
            { 
                Name ="Wick", //物件初始化-2:建立物件時，即初始化
                Age = 50
            };
            MessageBox.Show("Name:" + mem2.Name +
                "Age:" + mem2.Age);
        }

        /*private void btnCountAge_Click(object sender, EventArgs e)
        {
            string result = CountAge(2000);
            MessageBox.Show(result);
        }
        string CountAge(int bYear)
        {
           int Age = DateTime.Now.Year - bYear;
            return "你的年齡是"+Age+"歲。";
        }*/
     } 
}
