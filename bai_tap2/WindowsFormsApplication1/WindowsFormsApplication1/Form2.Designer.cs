namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.MycontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuDisplayTime = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplayDate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.MycontextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.ContextMenuStrip = this.MycontextMenu;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(348, 170);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(154, 24);
            this.lblHienThi.TabIndex = 0;
            this.lblHienThi.Text = "-----Nội dung------";
            // 
            // MycontextMenu
            // 
            this.MycontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDisplayTime,
            this.menuDisplayDate,
            this.menuExit});
            this.MycontextMenu.Name = "MycontextMenu";
            this.MycontextMenu.Size = new System.Drawing.Size(198, 76);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuDisplayTime
            // 
            this.menuDisplayTime.Name = "menuDisplayTime";
            this.menuDisplayTime.Size = new System.Drawing.Size(197, 24);
            this.menuDisplayTime.Text = "menuDisplayTime";
            this.menuDisplayTime.Click += new System.EventHandler(this.menuDisplayTime_Click);
            // 
            // menuDisplayDate
            // 
            this.menuDisplayDate.Name = "menuDisplayDate";
            this.menuDisplayDate.Size = new System.Drawing.Size(197, 24);
            this.menuDisplayDate.Text = "menuDisplayDate";
            this.menuDisplayDate.Click += new System.EventHandler(this.menuDisplayDate_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeyDisplayString = "Ctrl+T";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menuExit.Size = new System.Drawing.Size(197, 24);
            this.menuExit.Text = "menuExit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHienThi);
            this.Name = "Form2";
            this.Text = "ContextMenuStrip";
            this.MycontextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.ContextMenuStrip MycontextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDisplayTime;
        private System.Windows.Forms.ToolStripMenuItem menuDisplayDate;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}