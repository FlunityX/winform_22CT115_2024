namespace WindowsFormsApplication2
{
    partial class Form5
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
            this.Li_DSSanPham = new System.Windows.Forms.ListBox();
            this.btnXoaDS = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemVT = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboVitri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.txtThemSPVitri = new System.Windows.Forms.TextBox();
            this.txtThemSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Li_DSSanPham
            // 
            this.Li_DSSanPham.FormattingEnabled = true;
            this.Li_DSSanPham.Location = new System.Drawing.Point(60, 149);
            this.Li_DSSanPham.Name = "Li_DSSanPham";
            this.Li_DSSanPham.Size = new System.Drawing.Size(120, 95);
            this.Li_DSSanPham.TabIndex = 0;
            this.Li_DSSanPham.SelectedIndexChanged += new System.EventHandler(this.Li_DSSanPham_SelectedIndexChanged);
            // 
            // btnXoaDS
            // 
            this.btnXoaDS.Location = new System.Drawing.Point(401, 356);
            this.btnXoaDS.Name = "btnXoaDS";
            this.btnXoaDS.Size = new System.Drawing.Size(99, 34);
            this.btnXoaDS.TabIndex = 1;
            this.btnXoaDS.Text = "Xóa danh sách sản phẩm";
            this.btnXoaDS.UseVisualStyleBackColor = true;
            this.btnXoaDS.Click += new System.EventHandler(this.btnXoaDS_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(163, 347);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 43);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa Sản Phẩm";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemVT
            // 
            this.btnThemVT.Location = new System.Drawing.Point(611, 167);
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(75, 23);
            this.btnThemVT.TabIndex = 3;
            this.btnThemVT.Text = "thêm";
            this.btnThemVT.UseVisualStyleBackColor = true;
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(451, 209);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(451, 125);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thêm sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thêm Sản phẩm";
            // 
            // CboVitri
            // 
            this.CboVitri.FormattingEnabled = true;
            this.CboVitri.Location = new System.Drawing.Point(484, 169);
            this.CboVitri.Name = "CboVitri";
            this.CboVitri.Size = new System.Drawing.Size(121, 21);
            this.CboVitri.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "nhập sản phẩm cần tìm";
            // 
            // txtTimSP
            // 
            this.txtTimSP.Location = new System.Drawing.Point(312, 209);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(100, 20);
            this.txtTimSP.TabIndex = 11;
            // 
            // txtThemSPVitri
            // 
            this.txtThemSPVitri.Location = new System.Drawing.Point(312, 165);
            this.txtThemSPVitri.Name = "txtThemSPVitri";
            this.txtThemSPVitri.Size = new System.Drawing.Size(100, 20);
            this.txtThemSPVitri.TabIndex = 12;
            // 
            // txtThemSP
            // 
            this.txtThemSP.Location = new System.Drawing.Point(312, 127);
            this.txtThemSP.Name = "txtThemSP";
            this.txtThemSP.Size = new System.Drawing.Size(100, 20);
            this.txtThemSP.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vị trí thêm :";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 546);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThemSP);
            this.Controls.Add(this.txtThemSPVitri);
            this.Controls.Add(this.txtTimSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboVitri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemVT);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXoaDS);
            this.Controls.Add(this.Li_DSSanPham);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Li_DSSanPham;
        private System.Windows.Forms.Button btnXoaDS;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemVT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboVitri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimSP;
        private System.Windows.Forms.TextBox txtThemSPVitri;
        private System.Windows.Forms.TextBox txtThemSP;
        private System.Windows.Forms.Label label5;
    }
}