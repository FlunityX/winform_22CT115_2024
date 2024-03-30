using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            // Xóa các nút hiện tại trên TreeView
            treeView1.Nodes.Clear();

            
             // Lấy đường dẫn thư mục gốc
            string rootPath = @"D:\"; // Thay đổi đường dẫn thư mục gốc tùy theo nhu cầu

            // Gọi phương thức để hiển thị các thư mục và tệp tin
            DisplayDirectories(rootPath, treeView1.Nodes);
        }
        private  void DisplayDirectories(string path, TreeNodeCollection parentNode)
        {
            try
            {
                // Lấy danh sách các thư mục con trong thư mục được chỉ định
                string[] directories = Directory.GetDirectories(path);

               
            
                 // Thêm mỗi thư mục con vào TreeView
               foreach (string directory in directories)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(directory));
                    parentNode.Add(node);

                    // Đệ quy để hiển thị các thư mục con của thư mục hiện tại
                    DisplayDirectories(directory, node.Nodes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
       
    
