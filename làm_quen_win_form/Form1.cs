namespace làm_quen_win_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_tính_Click(object sender, EventArgs e)
        {
            double a, b, h, dtxq, dttp, tt;
            if (!double.TryParse(txta.Text, out a))
            {
                a = 0;
                txta.Text = "0";
            }
            if (!double.TryParse(txtb.Text, out b))
            {
                b = 0;
                txtb.Text = "0";
            }
            if (!double.TryParse(txtc.Text, out h))
            {
                h = 0;
                txtc.Text = "0";
            }
            dtxq = h * 2 * (a + b);
            dttp = dtxq + 2 * a * b;
            tt = a * b * h;
            txtd.Text = Convert.ToString(dtxq);
            txte.Text = Convert.ToString(dttp);
            txtf.Text = Convert.ToString(tt);
        }

        private void btn_thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
