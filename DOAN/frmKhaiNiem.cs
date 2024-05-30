using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class frmKhaiNiem : Form
    {
        bool flag = false;
        Dictionary<string, string> dicImage = new Dictionary<string, string>();
        Dictionary<string, string> dicRelated = new Dictionary<string, string>();
        public frmKhaiNiem()
        {
            InitializeComponent();
            lblRelate.Visible = false;
            lblNdLienQuan.Visible = false;
        }
        private TreeNode CreateNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            directoryNode.Name = directoryInfo.Name;
            foreach (var file in directoryInfo.GetFiles())
            {
                if (file.Extension == ".txt" && file.Name != "related.txt")
                {
                    string nd = "";
                    string[] tmp = File.ReadAllLines(file.FullName);
                    foreach (string s in tmp)
                    {
                        nd += s + "\n";
                    }
                    directoryNode.Tag = nd;
                }
                if (file.Extension == ".txt" && file.Name == "related.txt")
                {
                    string nd = "";
                    string[] tmp = File.ReadAllLines(file.FullName);
                    foreach (string s in tmp)
                    {
                        nd += s;
                    }
                    directoryNode.Name = directoryInfo.Name + "R";
                    dicRelated.Add(directoryNode.Name, nd);
                }
                if (file.Extension == ".png" || file.Extension == ".jpg" || file.Extension == ".PNG")
                {
                    Console.WriteLine(file.Name);
                    dicImage[directoryInfo.Name] = file.FullName;
                }

            }
            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateNode(directory));
            }
            return directoryNode;
        }
        private void frmKhaiNiem_Load(object sender, EventArgs e)
        {
            DirectoryInfo dInfo = new DirectoryInfo(@"NoiDung"); // duyet qua cac folder trong folder NoiDung
            foreach (var directory in dInfo.GetDirectories()) //duyet qua cac folder trong folder con NoiDung
                treeView.Nodes.Add(CreateNode(directory));
        }


        private void lblRelate_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeView.Nodes)
            {
                if (node.Name == lblRelate.Text)
                {
                    treeView.SelectedNode = node;
                    node.EnsureVisible();
                    break;
                }
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblTitle.Text = e.Node.Text;
            richTextBox.Text = "";
            if (e.Node.Tag != null) richTextBox.Text = e.Node.Tag.ToString();
            picDemo.Image = null;
            lblRelate.Visible = false;
            lblNdLienQuan.Visible = false;
            foreach (var re in dicRelated)
            {
                if (e.Node.Name == re.Key)
                {
                    lblRelate.Visible = true;
                    lblNdLienQuan.Visible = true;
                    lblRelate.Text = re.Value;
                    break;
                }
            }
            foreach (var img in dicImage)
            {
                if (e.Node.Name == img.Key)
                {
                    picDemo.Load(img.Value);
                    picDemo.SizeMode = PictureBoxSizeMode.Zoom;
                    //picDemo.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                }
            }
        }
    }
}
