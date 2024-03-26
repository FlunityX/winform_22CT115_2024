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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string strngay = "";
            DateTime i = new DateTime();
            for (i = MyMCalendar.SelectionStart; i <=
            MyMCalendar.SelectionEnd; i = i.AddDays(1.0))
            {
                strngay += i.ToLongDateString() + "\n";
            }
            MessageBox.Show(strngay);
        }
    }
}
