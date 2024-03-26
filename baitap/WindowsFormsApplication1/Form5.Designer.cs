namespace WindowsFormsApplication1
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
            this.TV_Test = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.btnthemgoc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMoRong = new System.Windows.Forms.Button();
            this.btnThuNho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TV_Test
            // 
            this.TV_Test.LabelEdit = true;
            this.TV_Test.Location = new System.Drawing.Point(23, 84);
            this.TV_Test.Name = "TV_Test";
            this.TV_Test.Size = new System.Drawing.Size(248, 316);
            this.TV_Test.TabIndex = 0;
            this.TV_Test.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_Test_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TreeView";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiêu đều node:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(458, 53);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(100, 20);
            this.txtTieuDe.TabIndex = 3;
            // 
            // btnthemgoc
            // 
            this.btnthemgoc.Location = new System.Drawing.Point(469, 103);
            this.btnthemgoc.Name = "btnthemgoc";
            this.btnthemgoc.Size = new System.Drawing.Size(75, 23);
            this.btnthemgoc.TabIndex = 4;
            this.btnthemgoc.Text = "Thêm node gốc";
            this.btnthemgoc.UseVisualStyleBackColor = true;
            this.btnthemgoc.Click += new System.EventHandler(this.btnthemgoc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thêm node con tại vị trí";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(469, 235);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTatCa.TabIndex = 6;
            this.btnXoaTatCa.Text = "Xóa tất cả các node";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(469, 286);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(75, 23);
            this.btnXoaChon.TabIndex = 7;
            this.btnXoaChon.Text = "Xóa node đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(469, 337);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMoRong
            // 
            this.btnMoRong.Location = new System.Drawing.Point(36, 454);
            this.btnMoRong.Name = "btnMoRong";
            this.btnMoRong.Size = new System.Drawing.Size(75, 23);
            this.btnMoRong.TabIndex = 9;
            this.btnMoRong.Text = "+";
            this.btnMoRong.UseVisualStyleBackColor = true;
            this.btnMoRong.Click += new System.EventHandler(this.btnMoRong_Click);
            // 
            // btnThuNho
            // 
            this.btnThuNho.Location = new System.Drawing.Point(151, 454);
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.Size = new System.Drawing.Size(75, 23);
            this.btnThuNho.TabIndex = 10;
            this.btnThuNho.Text = "-";
            this.btnThuNho.UseVisualStyleBackColor = true;
            this.btnThuNho.Click += new System.EventHandler(this.btnThuNho_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 525);
            this.Controls.Add(this.btnThuNho);
            this.Controls.Add(this.btnMoRong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaChon);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnthemgoc);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TV_Test);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TV_Test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Button btnthemgoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnMoRong;
        private System.Windows.Forms.Button btnThuNho;
        private System.Windows.Forms.Button btnThoat;
    }
}