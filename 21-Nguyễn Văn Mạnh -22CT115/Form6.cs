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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 giây
            timer.Tick += Timer_Tick_Tick;
            timer.Start();
        }
        private void vlaue_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick_Tick(object sender, EventArgs e)
        {
            value.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
