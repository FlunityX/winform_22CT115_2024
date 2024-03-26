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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "" && txtLop.Text != "")
            {
                ListViewItem LVItem = new ListViewItem(txtLop.Text);
                ListViewItem.ListViewSubItem LVSItem = new
                ListViewItem.ListViewSubItem(LVItem, txtSoLuong.Text);
                LVItem.SubItems.Add(LVSItem);
                LVSItem = new ListViewItem.ListViewSubItem(LVItem,
                txtGVCN.Text);
                LVItem.SubItems.Add(LVSItem);
                MylistView.Items.Add(LVItem);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MylistView.Columns.Add("Tên Lớp", 160);
            MylistView.Columns.Add("Số lượng sinh viên", 140);
            MylistView.Columns.Add("GVCN", 100);
        }
    }
}
