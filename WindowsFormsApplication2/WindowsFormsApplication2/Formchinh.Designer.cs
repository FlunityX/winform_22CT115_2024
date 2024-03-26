namespace WindowsFormsApplication2
{
    partial class Formchinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formchinh));
            this.vd1 = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vd1
            // 
            this.vd1.Location = new System.Drawing.Point(72, 183);
            this.vd1.Name = "vd1";
            this.vd1.Size = new System.Drawing.Size(174, 73);
            this.vd1.TabIndex = 0;
            this.vd1.Text = "ví dụ 1";
            this.vd1.UseVisualStyleBackColor = true;
            this.vd1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(583, 166);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(109, 73);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "ví dụ 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 73);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ví dụ 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 94);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ví dụ 4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "bài tập";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(526, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 68);
            this.button4.TabIndex = 6;
            this.button4.Text = "ví dụ 5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Formchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(719, 626);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.vd1);
            this.Name = "Formchinh";
            this.Text = "Formchinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vd1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}