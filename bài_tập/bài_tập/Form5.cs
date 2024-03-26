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
    public partial class Form5 : Form
    {
        int chon = 3;
        DateTime dt = new DateTime();
        public Form5()
        {
            InitializeComponent();
        }

        private void MyMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MyTime_Tick(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            if (chon == 0)
                lblHienThi.Text = dt.Hour + ":" + dt.Minute + ":"
                + dt.Second;
            else
                lblHienThi.Text = dt.Date.ToLongDateString();
        }

      

        private void cboChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            chon = cboChucNang.SelectedIndex;
            dt = DateTime.Now;
            if (chon == 1)
            {
                lblHienThi.Text = dt.Date.ToLongDateString();
            }
            if (chon == 0)
            {
                lblHienThi.Text = dt.Hour + ":" + dt.Minute + ":"
                    + dt.Second;
            }
        }

        private void imtThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
