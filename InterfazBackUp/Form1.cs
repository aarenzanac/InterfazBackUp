using System;
using System.Collections;
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
        String path = @"D:\Programas\";
        //String path = @"C:\Facturae-3.4";
        static ArrayList seleccionArchivosCopia = new ArrayList();
        static ArrayList seleccionPathsCopia = new ArrayList();
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
            listViewSeleccion.SmallImageList = imageList1;
            if (treeView1.Nodes.Count != 0) {
                
                if (e.Node.Tag == "file")
                {
                    FileStream fileStream = File.Create(@"D:\" + e.Node.FullPath);
                    FileStream fs = fileStream;
                    seleccionArchivosCopia.Add(fs);
                    
                    String pathArchivo = e.Node.FullPath;
                    seleccionPathsCopia.Add(pathArchivo);

                    ListViewItem archivoAñadir = new ListViewItem(e.Node.Text);
                    //e.Node.ImageIndex = 1;
                    archivoAñadir.SubItems.Add(@"D:\" + pathArchivo);
                    listViewSeleccion.Items.Add(archivoAñadir);
                    MessageBox.Show(e.Node.Text + "Añadido");

                }
                else {
                    CreateDirectoryNodeSeleccion(@"D:\" + e.Node.FullPath);

                }

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
            {   
                directoryNode.Tag = "dir";
                directoryNode.ImageIndex = 0;
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));             
            }
            foreach (var file in directoryInfo.GetFiles()) {
                TreeNode archivo = new TreeNode(file.Name);
                archivo.Tag = "file";
                archivo.ImageIndex = 1;
                directoryNode.Nodes.Add(archivo);
            }
                
            return directoryNode;
        }


        private TreeNode CreateDirectoryNodeSeleccion(String path)
        {
            var directoryInfo = new DirectoryInfo(path);
            listViewSeleccion.SmallImageList = imageList1;
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Tag = "dir";
                directoryNode.Nodes.Add(CreateDirectoryNodeSeleccion(directory.FullName));
            }
            foreach (var file in directoryInfo.GetFiles())
            {
                FileStream fileStream = File.Create(file.DirectoryName);
                FileStream fs = fileStream;
                seleccionArchivosCopia.Add(fs);

                String pathArchivo = file.DirectoryName;
                seleccionPathsCopia.Add(pathArchivo);

                ListViewItem archivoAñadir = new ListViewItem(fs.Name);
                archivoAñadir.SubItems.Add(@"D:\" + pathArchivo);
                listViewSeleccion.Items.Add(archivoAñadir);
                //MessageBox.Show(e.Node.Text + "Añadido");
            }
            return directoryNode;
        }
    }

 
}
