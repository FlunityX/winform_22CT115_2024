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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            int i;
            i = txtNoiDung.Text.IndexOf(txtTimKiem.Text);
            if (i >= 0)
            {
                txtNoiDung.SelectionStart = i;
                txtNoiDung.SelectionLength = txtTimKiem.Text.Length;
                MessageBox.Show(txtNoiDung.SelectedText);
            }
            else
                MessageBox.Show("Không tìm thấy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNoiDung.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNoiDung.Cut();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNoiDung.Paste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNoiDung.Copy();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
