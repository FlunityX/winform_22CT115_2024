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
            this.components = new System.ComponentModel.Container();
            this.a = new System.Windows.Forms.StatusStrip();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.MyStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.a.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyStatusLabel});
            this.a.Location = new System.Drawing.Point(0, 82);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(397, 25);
            this.a.TabIndex = 0;
            this.a.Text = "statusStrip1";
            // 
            // MyTimer
            // 
            this.MyTimer.Enabled = true;
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyStatusLabel
            // 
            this.MyStatusLabel.Name = "MyStatusLabel";
            this.MyStatusLabel.Size = new System.Drawing.Size(151, 20);
            this.MyStatusLabel.Text = "toolStripStatusLabel1";
            this.MyStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 107);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.a);
            this.Name = "Form5";
            this.Text = "StatusStrip";
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip a;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel MyStatusLabel;
    }
}