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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
        }
    }
}
