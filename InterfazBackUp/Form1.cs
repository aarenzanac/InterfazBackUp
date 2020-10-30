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

namespace InterfazBackUp
{
    public partial class Form1 : Form
    {
        String path = @"C:\Users\aaren\OneDrive";
        public Form1()
        {
            InitializeComponent();
            //CrearTreeView();
            ListDirectory(treeView1, path);

        }

        public void CrearTreeView()
        {
            treeView1.Nodes.Clear();
            treeView1.ImageList = imageList1;
            treeView1.Nodes.Add("TreeView", "Personas", 0);
            treeView1.Nodes[0].Nodes.Add("1", "Alejandro", 1);
            treeView1.Nodes[0].Nodes.Add("1", "Lara", 1);
            treeView1.Nodes[0].Nodes.Add("1", "Sofía", 1);
            treeView1.Nodes[0].Nodes.Add("1", "Emma", 1);
        }

        private void buttonExpandir_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void buttonContraer_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView1.Nodes.Count != 0) {
                MessageBox.Show(e.Node.Text);
              
                
            }
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView1.Nodes.Clear();
            treeView1.ImageList = imageList1;
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView1.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }
    }

 
}
