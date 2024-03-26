using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baitap
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string regexPattern = @"^(0?[1-9]|[12][0-9]|3[01])/(0?[1-9]|1[0-2])/\d{4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(txt2.Text, regexPattern))
            {
                errorProvider1.SetError(txt2, "Ngày sinh phải có định dạng dd/mm/yyyy");
            }
            else
            {
                errorProvider1.SetError(txt2, ""); // Xóa thông báo lỗi nếu nội dung hợp lệ
            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập số vào TextBox3 hay không
            if (!double.TryParse(txt3.Text, out double result))
            {
                errorProvider1.SetError(txt3, "Nhập số");
            }
            else
            {
                errorProvider1.SetError(txt3, ""); // Xóa thông báo lỗi nếu nội dung hợp lệ
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập có phải là chữ không
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là chữ và không phải là ký tự điều khiển (control key), không cho phép nhập
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string content = "Họ tên: " + txt1.Text + "\n";
            content += "Ngày sinh: " + txt2.Text + "\n";
            content += "Điểm trung bình: " + txt3.Text;

            MessageBox.Show(content, "Thông tin đăng kí", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
