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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            {
                txtNam.Text = (DTP1.Value.Year).ToString();
                txtNgay.Text = (DTP1.Value.Day).ToString();
                txtThang.Text = (DTP1.Value.Month).ToString();
                txtGiaTri.Text = DTP1.Value.ToString();
                txtThu.Text = (DTP1.Value.DayOfWeek).ToString();
                txtNgayThangNam.Text = DTP1.Value.Date.ToString();
            }
        }

        private void DTP1_ValueChanged(object sender, EventArgs e)
        {
            {
                txtNam.Text = (DTP1.Value.Year).ToString();
                txtNgay.Text = (DTP1.Value.Day).ToString();
                txtThang.Text = (DTP1.Value.Month).ToString();
                txtGiaTri.Text = DTP1.Value.ToString();
                txtThu.Text = (DTP1.Value.DayOfWeek).ToString();
                txtNgayThangNam.Text = DTP1.Value.Date.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
