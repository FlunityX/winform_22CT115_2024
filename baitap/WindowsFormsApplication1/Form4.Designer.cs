namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.MylistView = new System.Windows.Forms.ListView();
            this.a = new System.Windows.Forms.Label();
            this.txtGVCN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm lớp học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng sinh viên:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(336, 242);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(336, 166);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(100, 20);
            this.txtLop.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(540, 169);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 76);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // MylistView
            // 
            this.MylistView.GridLines = true;
            this.MylistView.Location = new System.Drawing.Point(94, 345);
            this.MylistView.Name = "MylistView";
            this.MylistView.Size = new System.Drawing.Size(500, 97);
            this.MylistView.TabIndex = 7;
            this.MylistView.UseCompatibleStateImageBehavior = false;
            this.MylistView.View = System.Windows.Forms.View.Details;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(102, 310);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(37, 13);
            this.a.TabIndex = 8;
            this.a.Text = "GVCN";
            // 
            // txtGVCN
            // 
            this.txtGVCN.Location = new System.Drawing.Point(336, 303);
            this.txtGVCN.Name = "txtGVCN";
            this.txtGVCN.Size = new System.Drawing.Size(100, 20);
            this.txtGVCN.TabIndex = 9;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 522);
            this.Controls.Add(this.txtGVCN);
            this.Controls.Add(this.a);
            this.Controls.Add(this.MylistView);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView MylistView;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtGVCN;
    }
}