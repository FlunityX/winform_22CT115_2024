namespace WindowsFormsApplication3
{
    partial class form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form3));
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.myFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(98, 87);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(225, 176);
            this.myPictureBox.TabIndex = 0;
            this.myPictureBox.TabStop = false;
            // 
            // myImageList
            // 
            this.myImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImageList.ImageStream")));
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myImageList.Images.SetKeyName(0, "castle_forest_autumn_approaching_storm-wallpaper-3554x1999.jpg");
            this.myImageList.Images.SetKeyName(1, "Chrysanthemum.jpg");
            this.myImageList.Images.SetKeyName(2, "Desert.jpg");
            this.myImageList.Images.SetKeyName(3, "Hydrangeas.jpg");
            this.myImageList.Images.SetKeyName(4, "Jellyfish.jpg");
            this.myImageList.Images.SetKeyName(5, "Koala.jpg");
            this.myImageList.Images.SetKeyName(6, "magic_path-wallpaper-3840x2160.jpg");
            this.myImageList.Images.SetKeyName(7, "orion_nebula_6-wallpaper-3840x2160.jpg");
            this.myImageList.Images.SetKeyName(8, "Penguins.jpg");
            this.myImageList.Images.SetKeyName(9, "skogafoss_waterfall_iceland-wallpaper-3840x2160.jpg");
            this.myImageList.Images.SetKeyName(10, "the_devils_pulpit_scotland_united_kingdom-wallpaper-3840x2160.jpg");
            this.myImageList.Images.SetKeyName(11, "Tulips.jpg");
            // 
            // myFlowLayoutPanel
            // 
            this.myFlowLayoutPanel.AutoScroll = true;
            this.myFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myFlowLayoutPanel.Location = new System.Drawing.Point(98, 302);
            this.myFlowLayoutPanel.Name = "myFlowLayoutPanel";
            this.myFlowLayoutPanel.Size = new System.Drawing.Size(235, 100);
            this.myFlowLayoutPanel.TabIndex = 1;
            this.myFlowLayoutPanel.WrapContents = false;
            this.myFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 427);
            this.Controls.Add(this.myFlowLayoutPanel);
            this.Controls.Add(this.myPictureBox);
            this.Name = "form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FlowLayoutPanel_Load);
            this.Click += new System.EventHandler(this.FlowLayoutPanel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.ImageList myImageList;
        private System.Windows.Forms.FlowLayoutPanel myFlowLayoutPanel;
    }
}