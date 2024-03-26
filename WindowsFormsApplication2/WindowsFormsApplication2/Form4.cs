using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnDoimau_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Vàng")
            lblHienThi.ForeColor = Color.Yellow;
          if (comboBox1.Text == "Đỏ") 
              lblHienThi.ForeColor= Color.Red;
            if (comboBox1.Text == "Đen")
           lblHienThi.ForeColor = Color.Black;
           if (comboBox1.Text == "Xanh")
               lblHienThi.ForeColor = Color.Blue; 
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
