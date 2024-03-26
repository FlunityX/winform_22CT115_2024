using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đăng đăng nhập thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ttpDangNhap.SetToolTip(txtDangNhap,
          "Nhập chuỗi ký tự không dấu, không khoảng trắng");
            ttpmk.SetToolTip(txtMatKhau,
            "Nhập ít nhất 6 ký tự, nhiều nhất 10 ký tự");
        }

        private void ttpmk_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ttpDangNhap_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
