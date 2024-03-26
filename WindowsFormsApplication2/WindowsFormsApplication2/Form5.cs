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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Li_DSSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ThietLapViTriComboBox()
        {
           CboVitri.Items.Clear(); int chiso =
            Li_DSSanPham.Items.Count; for (int i = 0; i < chiso; i++)
                CboVitri.Items.Add(i.ToString());
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            ThietLapViTriComboBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtThemSP.Text.Trim() != "")
            {
                Li_DSSanPham.Items.Add(txtThemSP.Text);
                txtThemSP.Text = ""; ThietLapViTriComboBox();
            }
            else
                MessageBox.Show("Phải nhập tên sản phẩm");
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            if (txtThemSPVitri.Text.Trim() != "")
            {
                if (CboVitri.Text != "")
                {
                    Li_DSSanPham.Items.Insert(Convert.ToInt32(CboVitri.Text),
                    txtThemSPVitri.Text);
                    txtThemSPVitri.Text = "";
                    ThietLapViTriComboBox();
                }
                else
                    MessageBox.Show("Phải chọn vị trí thêm hợp lệ");
            }
            else
                MessageBox.Show("Phải nhập tên sản phẩm ");
        }

        private void btnXoaDS_Click(object sender, EventArgs e)
        {
            if (Li_DSSanPham.Items.Count > 0)
                Li_DSSanPham.Items.Clear();
            else
                MessageBox.Show("Danh sách sản phẩm chưa có gì");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Li_DSSanPham.Items.Count > 0)
                Li_DSSanPham.Items.Clear();
            else
                MessageBox.Show("Danh sách sản phẩm chưa có gì");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimSP.Text != "")
            {
                if (Li_DSSanPham.Items.Contains(txtTimSP.Text) == true)
                    MessageBox.Show("Tìm thấy sản phẩm");
                else
                    MessageBox.Show("Không Tìm thấy sản phẩm ");
            }
            else
                MessageBox.Show("Nhập tên sản phẩm cần tìm");
        }

    }
}
