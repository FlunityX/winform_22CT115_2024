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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void thoát_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label3.ForeColor = Color.Blue;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label3.ForeColor = Color.Red;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label3.ForeColor = Color.Black;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label3.Font = new
                    System.Drawing.Font("Microsoft Sans Serif", 12F,
                    System.Drawing.FontStyle.Bold);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                label3.Font = new
                    System.Drawing.Font("Microsoft Sans Serif", 12F,
                    System.Drawing.FontStyle.Italic);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                label3.Font = new
                    System.Drawing.Font("Microsoft Sans Serif", 12F,
                    System.Drawing.FontStyle.Underline);
            }
        }
    }
}
