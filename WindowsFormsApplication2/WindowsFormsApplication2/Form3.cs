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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string st = "";
            foreach (string item in listBox1.SelectedItems)
                st = st + item + "\n";
            MessageBox.Show(st);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s;
         int n;
        n = listBox1.SelectedIndex;
       if (n >= 0)
        {
       s = txtThem.Text;
          listBox1.Items.Insert(n, s);
        }
        else
       MessageBox.Show("Bạn chưa chọn");
       }

        private void button3_Click(object sender, EventArgs e)
        {
        string s;
         s = txtnoidung.Text;
         listBox1.Items.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if (n == -1)
                n = listBox1.Items.Count - 1;
            listBox1.Items.RemoveAt(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        }
    }

