using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baitap
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }




        private void Form7_Load(object sender, EventArgs e)
        {

        }





        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            textBox1.Text += "Date : " + currentDate.ToString("dd-MM-yyyy") ;
        }

        private void time_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            textBox1.Text+= "Time : " + currentTime.ToString("HH:mm:ss");
        }
    }
}
