using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục Load Form?", "Bạn có phải Nguyễn Văn Mạnh - Số máy 32 ?", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input = txtChuoi.Text.Trim();
            input = System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " "); // Loại bỏ khoảng trắng thừa
            input = System.Text.RegularExpressions.Regex.Replace(input, @"\s*([.,:!?;])\s*", "$1 "); // Xử lý dấu câu
            txtChuoi.Text = input;
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            string input = txtChuoi.Text.ToLower(); // Chuyển thành chữ thường
            string[] words = input.Split(' ');

            Dictionary<string, int> wordFreq = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string cleanedWord = word.Trim(',', '.', ':', '!', '?', ';');
                if (wordFreq.ContainsKey(cleanedWord))
                {
                    wordFreq[cleanedWord]++;
                }
                else
                {
                    wordFreq[cleanedWord] = 1;
                }
            }

            // Hiển thị thống kê
            lvThongKe.Items.Clear();
            foreach (var pair in wordFreq.OrderBy(x => x.Key))
            {
                ListViewItem item = new ListViewItem(pair.Key);
                item.SubItems.Add(pair.Value.ToString());
                lvThongKe.Items.Add(item);
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu thành công");
            Close();
        }

        private void txtChuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
