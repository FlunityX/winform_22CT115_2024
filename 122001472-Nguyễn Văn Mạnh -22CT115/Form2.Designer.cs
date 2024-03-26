namespace baitap
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbValue = new Label();
            label3 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            txtInterval = new TextBox();
            txtIncrement = new TextBox();
            btnStart = new Button();
            btnStop = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 27);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "ProgressBar";
            // 
            // lbValue
            // 
            lbValue.AutoSize = true;
            lbValue.Location = new Point(379, 87);
            lbValue.Name = "lbValue";
            lbValue.Size = new Size(35, 15);
            lbValue.TabIndex = 1;
            lbValue.Text = "Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 292);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Increment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 339);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 3;
            label4.Text = "Seconds Interval";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(246, 123);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(325, 23);
            progressBar1.TabIndex = 4;
            // 
            // txtInterval
            // 
            txtInterval.Location = new Point(365, 331);
            txtInterval.Name = "txtInterval";
            txtInterval.Size = new Size(100, 23);
            txtInterval.TabIndex = 5;
            // 
            // txtIncrement
            // 
            txtIncrement.Location = new Point(365, 292);
            txtIncrement.Name = "txtIncrement";
            txtIncrement.Size = new Size(100, 23);
            txtIncrement.TabIndex = 6;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(290, 197);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 7;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(437, 197);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 8;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // button1
            // 
            button1.Location = new Point(578, 308);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(txtIncrement);
            Controls.Add(txtInterval);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbValue);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbValue;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
        private TextBox txtInterval;
        private TextBox txtIncrement;
        private Button btnStart;
        private Button btnStop;
        private Button button1;
    }
}