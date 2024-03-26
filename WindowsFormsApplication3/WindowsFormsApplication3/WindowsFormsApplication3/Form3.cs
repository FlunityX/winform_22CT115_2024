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
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < myImageList.Images.Count; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = myImageList.Images[i];
                pic.Size = new Size(50, 50);
                pic.Click += new EventHandler(FlowLayoutPanel_Click);
                myFlowLayoutPanel.Controls.Add(pic);
            }
        }

        private void FlowLayoutPanel_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox pic = (PictureBox)sender;
                myPictureBox.Image = pic.Image;
            }
            catch (Exception ex) { }
        }
    }
}
