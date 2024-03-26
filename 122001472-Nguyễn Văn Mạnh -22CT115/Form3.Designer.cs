namespace baitap
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            txtChuoi = new TextBox();
            lvThongKe = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            btnthongke = new Button();
            BtnLuu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 44);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập Chuỗi ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(534, 44);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "kết quả thống kê";
            // 
            // txtChuoi
            // 
            txtChuoi.Location = new Point(117, 83);
            txtChuoi.Multiline = true;
            txtChuoi.Name = "txtChuoi";
            txtChuoi.Size = new Size(158, 185);
            txtChuoi.TabIndex = 2;
            txtChuoi.TextChanged += txtChuoi_TextChanged;
            // 
            // lvThongKe
            // 
            lvThongKe.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader4 });
            lvThongKe.GridLines = true;
            lvThongKe.Location = new Point(512, 72);
            lvThongKe.Name = "lvThongKe";
            lvThongKe.Size = new Size(151, 205);
            lvThongKe.TabIndex = 3;
            lvThongKe.UseCompatibleStateImageBehavior = false;
            lvThongKe.View = View.Details;
            lvThongKe.SelectedIndexChanged += lvThongKe_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TỪ ĐƠN";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TẦN SỐ";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(138, 307);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Chuẩn hoá";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnthongke
            // 
            btnthongke.Location = new Point(453, 307);
            btnthongke.Name = "btnthongke";
            btnthongke.Size = new Size(75, 23);
            btnthongke.TabIndex = 5;
            btnthongke.Text = "Thống kê";
            btnthongke.UseVisualStyleBackColor = true;
            btnthongke.Click += btnthongke_Click;
            // 
            // BtnLuu
            // 
            BtnLuu.Location = new Point(669, 307);
            BtnLuu.Name = "BtnLuu";
            BtnLuu.Size = new Size(75, 23);
            BtnLuu.TabIndex = 6;
            BtnLuu.Text = "Lưu";
            BtnLuu.UseVisualStyleBackColor = true;
            BtnLuu.Click += BtnLuu_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLuu);
            Controls.Add(btnthongke);
            Controls.Add(button1);
            Controls.Add(lvThongKe);
            Controls.Add(txtChuoi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = " bài 4.2";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtChuoi;
        private ListView lvThongKe;
        private Button button1;
        private Button btnthongke;
        private Button BtnLuu;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
    }
}