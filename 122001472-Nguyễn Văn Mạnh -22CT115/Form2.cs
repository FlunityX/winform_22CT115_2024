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
    public partial class Form2 : Form
    {
        private int minimumValue;
        private int maximumValue;
        private int incrementValue;
        private int interval;

        private Thread progressBarThread;
        private bool isRunning;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtIncrement.Text, out incrementValue) || !int.TryParse(txtInterval.Text, out interval))
            {
                MessageBox.Show("Invalid input. Please enter valid values for increment and interval.");
                return;
            }

            minimumValue = progressBar1.Minimum;
            maximumValue = progressBar1.Maximum;
            isRunning = true;

            // Disable text boxes and start button
            txtIncrement.ReadOnly = true;
            txtInterval.ReadOnly = true;
            btnStart.Enabled = false;

            progressBarThread = new Thread(UpdateProgressBar);
            progressBarThread.Start();
        }

        private void UpdateProgressBar()
        {
            int value = minimumValue;

            while (isRunning)
            {
                value += incrementValue;

                // Wrap around to minimum value if value exceeds maximum value
                if (value >= maximumValue)
                {
                    value = minimumValue;
                }

                // Update the progress bar and label on the UI thread
                Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value = value;
                    lbValue.Text = value.ToString();
                });

                Thread.Sleep(interval);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isRunning = false;

            // Enable text boxes and start button
            txtIncrement.ReadOnly = false;
            txtInterval.ReadOnly = false;
            btnStart.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
