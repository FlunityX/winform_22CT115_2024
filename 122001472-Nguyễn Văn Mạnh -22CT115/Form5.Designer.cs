namespace baitap
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
            TreeNode treeNode1 = new TreeNode("Application");
            TreeNode treeNode2 = new TreeNode("Program File", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Public");
            TreeNode treeNode4 = new TreeNode("User", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("Admin");
            TreeNode treeNode6 = new TreeNode("Windows", new TreeNode[] { treeNode5 });
            TreeNode treeNode7 = new TreeNode("Core");
            TreeNode treeNode8 = new TreeNode("Intel", new TreeNode[] { treeNode7 });
            TreeNode treeNode9 = new TreeNode("HE DIEU HANH (C:)", new TreeNode[] { treeNode2, treeNode4, treeNode6, treeNode8 });
            TreeNode treeNode10 = new TreeNode("Nhạc");
            TreeNode treeNode11 = new TreeNode("Game Nro");
            TreeNode treeNode12 = new TreeNode("Phần mềm", new TreeNode[] { treeNode11 });
            TreeNode treeNode13 = new TreeNode("Phim Việt Nam");
            TreeNode treeNode14 = new TreeNode("Phim", new TreeNode[] { treeNode13 });
            TreeNode treeNode15 = new TreeNode("Hình ảnh");
            TreeNode treeNode16 = new TreeNode("GIAI TRI (D:)", new TreeNode[] { treeNode10, treeNode12, treeNode14, treeNode15 });
            TreeNode treeNode17 = new TreeNode("Việc vặt");
            TreeNode treeNode18 = new TreeNode("CONG VIEC (E:)", new TreeNode[] { treeNode17 });
            button1 = new Button();
            button2 = new Button();
            treeView1 = new TreeView();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(222, 355);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "hiển thị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(435, 355);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(248, 54);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node7";
            treeNode1.Text = "Application";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Program File";
            treeNode3.Name = "Node8";
            treeNode3.Text = "Public";
            treeNode4.Name = "Node2";
            treeNode4.Text = "User";
            treeNode5.Name = "Node9";
            treeNode5.Text = "Admin";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Windows";
            treeNode7.Name = "Node15";
            treeNode7.Text = "Core";
            treeNode8.Name = "Node4";
            treeNode8.Text = "Intel";
            treeNode9.Name = "Node0";
            treeNode9.Text = "HE DIEU HANH (C:)";
            treeNode10.Name = "Node6";
            treeNode10.Text = "Nhạc";
            treeNode11.Name = "Node13";
            treeNode11.Text = "Game Nro";
            treeNode12.Name = "Node10";
            treeNode12.Text = "Phần mềm";
            treeNode13.Name = "Node14";
            treeNode13.Text = "Phim Việt Nam";
            treeNode14.Name = "Node11";
            treeNode14.Text = "Phim";
            treeNode15.Name = "Node12";
            treeNode15.Text = "Hình ảnh";
            treeNode16.Name = "Node5";
            treeNode16.Text = "GIAI TRI (D:)";
            treeNode17.Name = "Node17";
            treeNode17.Text = "Việc vặt";
            treeNode18.Name = "Node16";
            treeNode18.Text = "CONG VIEC (E:)";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode9, treeNode16, treeNode18 });
            treeView1.PathSeparator = "";
            treeView1.Size = new Size(262, 273);
            treeView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Tree View";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TreeView treeView1;
        private Label label1;
    }
}