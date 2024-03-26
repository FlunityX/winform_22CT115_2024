namespace WindowsFormsApplication2
{
    partial class Form4
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
            this.text = new System.Windows.Forms.Label();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDoimau = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(109, 143);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(55, 13);
            this.text.TabIndex = 0;
            this.text.Text = "Chọn màu";
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Location = new System.Drawing.Point(109, 277);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(193, 13);
            this.lblHienThi.TabIndex = 1;
            this.lblHienThi.Text = "Trường Sa, Hoàng Sa là Của Viẹt Nam ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vàng",
            "Đỏ ",
            "Đen ",
            "Xanh"});
            this.comboBox1.Location = new System.Drawing.Point(211, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnDoimau
            // 
            this.btnDoimau.Location = new System.Drawing.Point(378, 138);
            this.btnDoimau.Name = "btnDoimau";
            this.btnDoimau.Size = new System.Drawing.Size(75, 23);
            this.btnDoimau.TabIndex = 3;
            this.btnDoimau.Text = "  Đổi màu ";
            this.btnDoimau.UseVisualStyleBackColor = true;
            this.btnDoimau.Click += new System.EventHandler(this.btnDoimau_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(523, 138);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 4;
            this.BtnThoat.Text = "   Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 424);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.btnDoimau);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.text);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDoimau;
        private System.Windows.Forms.Button BtnThoat;
    }
}