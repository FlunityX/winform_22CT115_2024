using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_tập
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
             for (int i = 0; i < MyImgList.Images.Count; i++)
{ 
             cboChonHinh.Items.Add("Hinh" + i); }
             picHinh.BorderStyle = BorderStyle.Fixed3D;
        }

        private void cboChonHinh_SelectedValueChanged(object sender, EventArgs e)
        {
            //Thuộc tính Image của PictureBox là thuộc tính chỉ định
            //hình sẽ được hiển thị
            picHinh.Image =
            MyImgList.Images[cboChonHinh.SelectedIndex];
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
