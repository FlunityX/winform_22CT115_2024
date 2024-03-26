namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnoidung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Location = new System.Drawing.Point(67, 460);
            this.btn_hienthi.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(200, 55);
            this.btn_hienthi.TabIndex = 0;
            this.btn_hienthi.Text = "Hiển thị";
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.button1_Click);
            this.btn_hienthi.MouseLeave += new System.EventHandler(this.btn_hienthi_MouseLeave);
            this.btn_hienthi.MouseHover += new System.EventHandler(this.btn_hienthi_MouseHover);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(547, 460);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(200, 55);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(360, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "KHOA CÔNG NGHỆ THÔNG TIN";
            // 
            // lblnoidung
            // 
            this.lblnoidung.AutoSize = true;
            this.lblnoidung.Location = new System.Drawing.Point(387, 336);
            this.lblnoidung.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblnoidung.Name = "lblnoidung";
            this.lblnoidung.Size = new System.Drawing.Size(297, 31);
            this.lblnoidung.TabIndex = 4;
            this.lblnoidung.Text = "---- hiển thị nội dung ----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 827);
            this.Controls.Add(this.lblnoidung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_hienthi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnoidung;
    }
}

