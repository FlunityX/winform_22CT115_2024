using System.Windows.Forms;

namespace baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhấn ok sau đó phím F5 để mở", "Thông báo");

        }

        private void button8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Form8 myForm = new Form8();
                myForm.Show();
            }
            else
            {
                MessageBox.Show("Nhấn sai . bài tạm thời thoát ra");
               
            }
        }
    }
}
