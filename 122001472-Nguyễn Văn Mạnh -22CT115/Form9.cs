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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem ListView có chứa dữ liệu hay không
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Yêu cầu người dùng chọn vị trí lưu tập tin
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tập tin văn bản (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Ghi từng dòng dữ liệu vào tập tin
                        foreach (ListViewItem item in listView1.Items)
                        {
                            string line = item.SubItems[0].Text + " - " + item.SubItems[1].Text + " - " + item.SubItems[2].Text; ;
                            writer.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Lưu danh sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string item1 = textBox1.Text; // Lấy giá trị từ textBox1
            string item2 = comboBox1.Text; // Lấy giá trị từ comboBox1
            string item3 = textBox2.Text; // Lấy giá trị từ textBox2

            if (string.IsNullOrWhiteSpace(item2)) // Kiểm tra xem lớp đã được chọn chưa
            {
                MessageBox.Show("Vui lòng chọn lớp trước khi thêm vào danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu lớp chưa được chọn
            }
            if (string.IsNullOrWhiteSpace(item1))
            {
                MessageBox.Show("Vui lòng chọn Họ tên trước khi thêm vào danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu lớp chưa được chọn
            }
            if (string.IsNullOrWhiteSpace(item3))
            {
                MessageBox.Show("Vui lòng chọn số Học Bổng trước khi thêm vào danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu lớp chưa được chọn
            }
            // Tạo một ListViewItem để chứa dữ liệu
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = item1; // Thêm giá trị vào cột đầu tiên

            listViewItem.SubItems.Add(item2); // Thêm giá trị vào cột thứ hai
            listViewItem.SubItems.Add(item3); // Thêm giá trị vào cột thứ ba

            // Thêm ListViewItem vào ListView
            listView1.Items.Add(listViewItem);

            // Xóa dữ liệu trong textBox1, comboBox1 và textBox2
            textBox1.Text = string.Empty;
            comboBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
         
           
        }
        private void CopyMenuItemsFromParent()
        {
          
        }
    }
}
