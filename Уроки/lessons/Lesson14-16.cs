using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lessons
{
    public partial class Lesson14_16 : Form
    {
        public Lesson14_16()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                treeView1.Nodes.Add(addNodeTextBox.Text);
            }
            else
            {
                node.Nodes.Add(addNodeTextBox.Text);
            }
            addNodeTextBox.Text = "";
            addNodeTextBox.Focus();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;
        }

        private void removeAllButton_Click_1(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void removeButton_Click_1(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node != null)
            {
                treeView1.Nodes.Remove(node);
            }
            else
            {
                MessageBox.Show("Ничего не выделено");
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;
            TreeNode tn = FindNode(treeView1.Nodes, findNodeTextBox.Text);
            if (tn != null)
            {
                treeView1.SelectedNode = tn;
                treeView1.Focus();

            }
        }
        private TreeNode FindNode(TreeNodeCollection tnc, string name)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.Text == name)
                {
                    return tn;
                }
            }

            TreeNode node;
            foreach (TreeNode tn in tnc)
            {
                node = FindNode(tn.Nodes, name);
                if (node != null)
                {
                    return node;
                }
            }
            return null;
        }

    }
}

