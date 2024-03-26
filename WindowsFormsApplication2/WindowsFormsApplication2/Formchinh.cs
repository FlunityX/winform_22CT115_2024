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
    public partial class Formchinh : Form
    {
        public Formchinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
        }
    }
}
