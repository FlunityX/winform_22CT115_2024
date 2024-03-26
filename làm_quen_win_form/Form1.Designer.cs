namespace làm_quen_win_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txta = new TextBox();
            txtb = new TextBox();
            txtc = new TextBox();
            txtd = new TextBox();
            Btn_tính = new Button();
            btn_thoát = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txte = new TextBox();
            txtf = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(76, 160);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "Chiều dài A :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(76, 246);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 1;
            label2.Text = "Chiều rộng B :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(76, 337);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 2;
            label3.Text = "Chiều cao H :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(451, 157);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 21);
            label4.TabIndex = 3;
            label4.Text = "Diện tích xung quanh :";
            // 
            // txta
            // 
            txta.Location = new Point(263, 157);
            txta.Margin = new Padding(4);
            txta.Name = "txta";
            txta.Size = new Size(141, 29);
            txta.TabIndex = 4;
            // 
            // txtb
            // 
            txtb.Location = new Point(263, 246);
            txtb.Margin = new Padding(4);
            txtb.Name = "txtb";
            txtb.Size = new Size(141, 29);
            txtb.TabIndex = 5;
            // 
            // txtc
            // 
            txtc.Location = new Point(263, 335);
            txtc.Margin = new Padding(4);
            txtc.Name = "txtc";
            txtc.Size = new Size(141, 29);
            txtc.TabIndex = 6;
            // 
            // txtd
            // 
            txtd.Location = new Point(721, 154);
            txtd.Margin = new Padding(4);
            txtd.Name = "txtd";
            txtd.Size = new Size(141, 29);
            txtd.TabIndex = 7;
            // 
            // Btn_tính
            // 
            Btn_tính.BackColor = SystemColors.ActiveCaption;
            Btn_tính.Location = new Point(183, 461);
            Btn_tính.Margin = new Padding(4);
            Btn_tính.Name = "Btn_tính";
            Btn_tính.Size = new Size(151, 59);
            Btn_tính.TabIndex = 8;
            Btn_tính.Text = "Tính";
            Btn_tính.UseVisualStyleBackColor = false;
            Btn_tính.Click += Btn_tính_Click;
            // 
            // btn_thoát
            // 
            btn_thoát.BackColor = SystemColors.ActiveCaption;
            btn_thoát.Location = new Point(563, 461);
            btn_thoát.Margin = new Padding(4);
            btn_thoát.Name = "btn_thoát";
            btn_thoát.Size = new Size(150, 59);
            btn_thoát.TabIndex = 9;
            btn_thoát.Text = "Thoát";
            btn_thoát.UseVisualStyleBackColor = false;
            btn_thoát.Click += btn_thoát_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Coral;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Cursor = Cursors.AppStarting;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(139, 69);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(454, 32);
            label5.TabIndex = 10;
            label5.Text = "TÍNH CÁC DIỆN TÍCH HÌNH HỘP CHỮ NHẬT";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(451, 246);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(169, 21);
            label6.TabIndex = 11;
            label6.Text = "Diện tích toàn phần :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(451, 337);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 12;
            label7.Text = "Thể tích :";
            // 
            // txte
            // 
            txte.Location = new Point(721, 246);
            txte.Margin = new Padding(4);
            txte.Name = "txte";
            txte.Size = new Size(141, 29);
            txte.TabIndex = 13;
            // 
            // txtf
            // 
            txtf.Location = new Point(721, 337);
            txtf.Margin = new Padding(4);
            txtf.Name = "txtf";
            txtf.Size = new Size(141, 29);
            txtf.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 615);
            Controls.Add(txtf);
            Controls.Add(txte);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btn_thoát);
            Controls.Add(Btn_tính);
            Controls.Add(txtd);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txta;
        private TextBox txtb;
        private TextBox txtc;
        private TextBox txtd;
        private Button Btn_tính;
        private Button btn_thoát;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txte;
        private TextBox txtf;
    }
}
