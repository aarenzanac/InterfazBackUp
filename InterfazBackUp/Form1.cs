using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazBackUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CrearTreeView();
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
    }

 
}
