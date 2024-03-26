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
    public partial class form5 : Form
    {
        public form5()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SplitContainer_Load(object sender, EventArgs e)
        {
            myWebsite.Navigate("www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtLink.Text);
            listLinkWebsite.Items.Add(lvi);
            txtLink.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listLinkWebsite.FocusedItem.Text = txtLink.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = listLinkWebsite.FocusedItem.Index;
            listLinkWebsite.Items.RemoveAt(i);
            txtLink.Text = "";
            myWebsite.Navigate("www.google.com");
        }

        private void listLinkWebsite_MouseClick(object sender, MouseEventArgs e)
        {
            txtLink.Text = listLinkWebsite.FocusedItem.Text;
            if (e.Button == MouseButtons.Left)
                myWebsite.Navigate(listLinkWebsite.FocusedItem.Text);
        }
    }
}
