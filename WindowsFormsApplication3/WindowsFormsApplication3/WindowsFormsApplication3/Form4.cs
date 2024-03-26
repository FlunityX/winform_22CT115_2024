using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listNhanVien.SelectedItems)
            {
                lvi.SubItems[0].Text = txtTenNV.Text;
                lvi.SubItems[1].Text = txtChucVuNV.Text;
                lvi.SubItems[2].Text = txtHeSoLuongNV.Text;
                lvi.SubItems[3].Text = txtLuongCBNV.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtLuongCBNV.Text != "" && txtTenNV.Text != "" &&
       txtHeSoLuongNV.Text != "" && txtChucVuNV.Text != "")
       {
ListViewItem LVItem = new
ListViewItem(txtTenNV.Text);
ListViewItem.ListViewSubItem LVSItemCV = new
ListViewItem.ListViewSubItem(LVItem,
txtChucVuNV.Text);
ListViewItem.ListViewSubItem LVSItemHSL = new
ListViewItem.ListViewSubItem(LVItem,
txtHeSoLuongNV.Text);
ListViewItem.ListViewSubItem LVSItemLCB = new
ListViewItem.ListViewSubItem(LVItem,
txtLuongCBNV.Text);
LVItem.SubItems.Add(LVSItemCV);
LVItem.SubItems.Add(LVSItemHSL);
LVItem.SubItems.Add(LVSItemLCB);
listNhanVien.Items.Add(LVItem);
txtLuongCBNV.Text = "";
txtTenNV.Text = "";
txtHeSoLuongNV.Text = "";
txtChucVuNV.Text = "";
}else
MessageBox.Show("Phải nhập đầy đủ thông tin nhân viên");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listNhanVien.SelectedIndices.Count > 0)
            {
                listNhanVien.Items.RemoveAt(listNhanVien.FocusedItem.Index);
            }
            else
                MessageBox.Show("Phải chọn nhân viên muốn ");
        }

        private void listNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listNhanVien.SelectedItems)
            {
                txtTenNV.Text = lvi.SubItems[0].Text;
                txtChucVuNV.Text = lvi.SubItems[1].Text;
                txtHeSoLuongNV.Text = lvi.SubItems[2].Text;
                txtLuongCBNV.Text = lvi.SubItems[3].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listgiaovien.SelectedItems)
            {
                lvi.SubItems[0].Text = textBox1.Text;
                lvi.SubItems[1].Text = textBox2.Text;
                lvi.SubItems[2].Text = textBox3.Text;
                lvi.SubItems[3].Text = textBox4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" &&
           textBox3.Text != "" && textBox4.Text != ""){
               ListViewItem LVItem = new
               ListViewItem(textBox1.Text);
ListViewItem.ListViewSubItem LVSItemCV = new
ListViewItem.ListViewSubItem(LVItem,
textBox2.Text);
ListViewItem.ListViewSubItem LVSItemHSL = new
ListViewItem.ListViewSubItem(LVItem,
textBox3.Text);
ListViewItem.ListViewSubItem LVSItemLCB = new
ListViewItem.ListViewSubItem(LVItem,
textBox4.Text);
LVItem.SubItems.Add(LVSItemCV);
LVItem.SubItems.Add(LVSItemHSL);
LVItem.SubItems.Add(LVSItemLCB);
listgiaovien.Items.Add(LVItem);
textBox1.Text = "";
textBox2.Text = "";
textBox3.Text = "";
textBox4.Text = "";
}
            else
MessageBox.Show("Phải nhập đầy đủ thông tin giáo viên"); }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listNhanVien.SelectedItems)
            {
                textBox1.Text = lvi.SubItems[0].Text;
                textBox2.Text = lvi.SubItems[1].Text;
                textBox3.Text = lvi.SubItems[2].Text;
                textBox4.Text = lvi.SubItems[3].Text;
            }
            foreach (ListViewItem lvi in listgiaovien.SelectedItems)
            {
                txtTenNV.Text = lvi.SubItems[0].Text;
                txtChucVuNV.Text = lvi.SubItems[1].Text;
                txtHeSoLuongNV.Text = lvi.SubItems[2].Text;
                txtLuongCBNV.Text = lvi.SubItems[3].Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listgiaovien.SelectedIndices.Count > 0)
            {
                listgiaovien.Items.RemoveAt(listgiaovien.FocusedItem.Index);
            }
            else
                MessageBox.Show("Phải chọn giáo viên  ");
        }
        }
    }

