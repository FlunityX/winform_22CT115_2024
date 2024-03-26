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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Form8_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            fr9.ShowDialog();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 fr10 = new Form10();
            fr10.ShowDialog();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 fr11 = new Form11();
            fr11.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 fr12 = new Form12();
            fr12.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
