using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baitap
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            Display();

        }
        private void Display()
        {
            // Lấy giá trị datetime từ DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value;
            textBox1.Text = dateTimePicker1.Text;
            // Hiển thị ngày tháng năm trong các Textbox tương ứng
            textBox2.Text = selectedDate.ToString("dd");
            textBox3.Text = selectedDate.ToString("MM");
            textBox4.Text = selectedDate.ToString("yyyy");
            textBox5.Text = selectedDate.ToString("dddd");

            // Tính toán ngày thứ bao nhiêu trong năm (dựa trên 365 ngày)
            int dayOfYear = selectedDate.DayOfYear;
            textBox6.Text = dayOfYear.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Lấy đường dẫn web từ LinkLabel
            string url = "https://lhu.edu.vn/";

            // Mở trình duyệt web mặc định để hiển thị trang web
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Lấy đường dẫn web từ LinkLabel
            string url1 = "https://www.calculator.net/";

            // Mở trình duyệt web mặc định để hiển thị trang web
            Process.Start(new ProcessStartInfo(url1) { UseShellExecute = true });
        }
    }
}
