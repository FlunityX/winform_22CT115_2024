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
    public partial class Form2 : Form
    {
        int chon = 3;
        DateTime dt = new DateTime();
        public Form2()
        {
            InitializeComponent();
        }

        private void menuDisplayTime_Click(object sender, EventArgs e)
        {
            chon = 0;
        }

        private void menuDisplayDate_Click(object sender, EventArgs e)
        {
            chon = 1;
            lblHienThi.Text = dt.Date.ToLongDateString();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            chon = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            if (chon == 0)
            {
                lblHienThi.Text = dt.Hour + ":" + dt.Minute + ":"
                    + dt.Second;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
