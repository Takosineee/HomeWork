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
    public partial class Frm_M18_enum : Form
    {
        public Frm_M18_enum()
        {
            InitializeComponent();
        }

        private void btnValidation3_Click(object sender, EventArgs e)
        {
            EnumLab Role = EnumLab.Admin;
            if (Role == EnumLab.Admin)
            {
                btnProduct.Enabled = true;
            }
            else 
            {
                btnProduct.Enabled= false;
            }
        }

        //private void btnValidation_const_Click(object sender, EventArgs e)
        //{
        //    //Adimin=1
        //    //User=0
        //    const int Admin = 1, User = 0;


        //}

        private void btnValidation_switch_Click(object sender, EventArgs e)
        {
            EnumLab role= EnumLab.Admin;
            switch (role)
            {
                case EnumLab.Admin:
                    btnProduct.Enabled = true;
                    break;
                case EnumLab.User: 
                    btnProduct.Enabled = false; 
                    break;  
            }
        }
    }
}
