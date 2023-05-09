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
    public partial class Frm_M15_CTS : Form
    {
        public Frm_M15_CTS()
        {
            InitializeComponent();
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = a;
            MessageBox.Show("a=" + a + "," + "b=" + b);
            b = 200;
            MessageBox.Show("a=" + a + "," + "b=" + b);
        }

        private void btnReferenceType_Click(object sender, EventArgs e)
        {
            TextBox tb = txtReferenceType;
            tb.Text = "RT";
            tb.BackColor = Color.Black;
            tb.BackColor = Color.Yellow;

        }
    }
}
