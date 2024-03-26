namespace bài_tập
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
            this.components = new System.ComponentModel.Container();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.MyTime = new System.Windows.Forms.Timer(this.components);
            this.MyMenu = new System.Windows.Forms.MenuStrip();
            this.itmChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.cboChucNang = new System.Windows.Forms.ToolStripComboBox();
            this.imtThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.MyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(96, 143);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(53, 24);
            this.lblHienThi.TabIndex = 0;
            this.lblHienThi.Text = "………..";
            // 
            // MyTime
            // 
            this.MyTime.Enabled = true;
            this.MyTime.Tick += new System.EventHandler(this.MyTime_Tick);
            // 
            // MyMenu
            // 
            this.MyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmChucNang,
            this.cboChucNang});
            this.MyMenu.Location = new System.Drawing.Point(0, 0);
            this.MyMenu.Name = "MyMenu";
            this.MyMenu.Size = new System.Drawing.Size(824, 32);
            this.MyMenu.TabIndex = 1;
            this.MyMenu.Text = "MenuStrip";
            this.MyMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MyMenu_ItemClicked);
            // 
            // itmChucNang
            // 
            this.itmChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imtThoat});
            this.itmChucNang.Name = "itmChucNang";
            this.itmChucNang.Size = new System.Drawing.Size(111, 28);
            this.itmChucNang.Text = "itmChucNang";
            // 
            // cboChucNang
            // 
            this.cboChucNang.Items.AddRange(new object[] {
            "Hiển thị thời gian ",
            "Hiển thị ngày "});
            this.cboChucNang.Name = "cboChucNang";
            this.cboChucNang.Size = new System.Drawing.Size(121, 28);
            this.cboChucNang.Text = "cboChucNang";
            this.cboChucNang.SelectedIndexChanged += new System.EventHandler(this.cboChucNang_SelectedIndexChanged);
            // 
            // imtThoat
            // 
            this.imtThoat.Name = "imtThoat";
            this.imtThoat.ShortcutKeyDisplayString = "Ctrl + T";
            this.imtThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.imtThoat.Size = new System.Drawing.Size(171, 24);
            this.imtThoat.Text = "thoát";
            this.imtThoat.Click += new System.EventHandler(this.imtThoat_Click_1);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 460);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.MyMenu);
            this.MainMenuStrip = this.MyMenu;
            this.Name = "Form5";
            this.Text = "MenuStrip";
            this.MyMenu.ResumeLayout(false);
            this.MyMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Timer MyTime;
        private System.Windows.Forms.MenuStrip MyMenu;
        private System.Windows.Forms.ToolStripMenuItem itmChucNang;
        private System.Windows.Forms.ToolStripComboBox cboChucNang;
        private System.Windows.Forms.ToolStripMenuItem imtThoat;
    }
}