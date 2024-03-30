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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            if (chkbox_muasam.Checked == true)
            {
                str = "- " +chkbox_muasam.Text + "\n";
            }
            if (chkbox_nghenhac.Checked == true)
            {
                str = str + "- " + chkbox_nghenhac.Text + "\n";
            }
            if (chkbox_thethao.Checked == true)
            {
                str = str + "- " + chkbox_thethao.Text + "\n";
            }
            if (chkbox_xemphim.Checked == true)
            {
                str = str + "- " + chkbox_xemphim.Text + "\n";
            }
            if (chxbox_dulich.Checked == true)
            {
                str = str + "- "+ chxbox_dulich.Text;
            }

            if (str.Length > 0)
            {
                MessageBox.Show("Sở thích của bạn là: \n" + str);
            }
            else
            {
                MessageBox.Show("Không có sở thích nào bạn chọn!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            if (rdbtn_do.Checked == true)
            {
                str = rdbtn_do.Text + "\n";
            }
            if (rdbtn_hong.Checked == true)
            {
                str = rdbtn_hong.Text + "\n";
            }
            if (rdbtn_tim.Checked == true)
            {
                str = rdbtn_tim.Text + "\n";
            }
            if (rdbtn_trang.Checked == true)
            {
                str = rdbtn_trang.Text + "\n";
            }
            if (rdbtn_vang.Checked == true)
            {
                str = rdbtn_vang.Text;
            }

            if (str.Length > 0)
            {
                MessageBox.Show("Màu bạn thích là: \n" + str);
            }
            else
            {
                MessageBox.Show("Không có màu nào bạn chọn!!");
            }
        }
    }
}
