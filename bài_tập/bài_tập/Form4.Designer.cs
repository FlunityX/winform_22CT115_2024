namespace bài_tập
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboChonHinh = new System.Windows.Forms.ComboBox();
            this.MyImgList = new System.Windows.Forms.ImageList(this.components);
            this.picHinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn hình";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(141, 306);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboChonHinh
            // 
            this.cboChonHinh.FormattingEnabled = true;
            this.cboChonHinh.Location = new System.Drawing.Point(192, 105);
            this.cboChonHinh.Name = "cboChonHinh";
            this.cboChonHinh.Size = new System.Drawing.Size(121, 21);
            this.cboChonHinh.TabIndex = 3;
            this.cboChonHinh.SelectedValueChanged += new System.EventHandler(this.cboChonHinh_SelectedValueChanged);
            // 
            // MyImgList
            // 
            this.MyImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyImgList.ImageStream")));
            this.MyImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.MyImgList.Images.SetKeyName(0, "castle_forest_autumn_approaching_storm-wallpaper-3554x1999.jpg");
            this.MyImgList.Images.SetKeyName(1, "Chrysanthemum.jpg");
            this.MyImgList.Images.SetKeyName(2, "Desert.jpg");
            this.MyImgList.Images.SetKeyName(3, "Hydrangeas.jpg");
            this.MyImgList.Images.SetKeyName(4, "Jellyfish.jpg");
            this.MyImgList.Images.SetKeyName(5, "Koala.jpg");
            this.MyImgList.Images.SetKeyName(6, "Lighthouse.jpg");
            this.MyImgList.Images.SetKeyName(7, "magic_path-wallpaper-3840x2160.jpg");
            this.MyImgList.Images.SetKeyName(8, "orion_nebula_6-wallpaper-3840x2160.jpg");
            this.MyImgList.Images.SetKeyName(9, "Penguins.jpg");
            // 
            // picHinh
            // 
            this.picHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHinh.Location = new System.Drawing.Point(408, 66);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(229, 181);
            this.picHinh.TabIndex = 4;
            this.picHinh.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 503);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.cboChonHinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboChonHinh;
        private System.Windows.Forms.ImageList MyImgList;
        private System.Windows.Forms.PictureBox picHinh;
    }
}