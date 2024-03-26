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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblnoidung.Text = "bạn vừa bấm Mickey";
            lblnoidung.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_hienthi_MouseHover(object sender, EventArgs e)
        {
            lblnoidung.Text = "Mickey chào bạn";
            lblnoidung.ForeColor = Color.Blue;
        }

        private void btn_hienthi_MouseLeave(object sender, EventArgs e)
        {
        lblnoidung.Text = "Mickey tạm biệt bạn";
        lblnoidung.ForeColor = Color.Green;
        }
    }
}
