using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Security.AccessControl;

namespace Directory_Walker
{
    public partial class Form1 : Form
    {
        string rootDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = folderBrowserDialog1.ShowDialog();
            if(dlgResult == DialogResult.OK)
            {
                rootDirectory = folderBrowserDialog1.SelectedPath;
                textBox1.Text = rootDirectory;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dir = new DirectoryInfo(rootDirectory);
            var doc = GetDirectory(dir);
            TreeNode treeNode = treeView1.Nodes.Add("Root");
            LoadElements(doc, treeNode);
            doc.Save("dirStructure.xml");
        }

        public static XElement GetDirectory(DirectoryInfo dir)
        {
            var info = new XElement("dir", 
                new XAttribute("name", dir.Name));
            


            if (dir.Exists)
            {
                try
                {
                    foreach (var file in dir.GetFiles("*.???.txt"))
                    {
                        info.Add(new XElement("file",
                            new XAttribute("name", file.Name), new XAttribute("created", file.CreationTime.ToShortDateString())));
                    }

                    foreach (var subdir in dir.GetDirectories())
                    {
                        info.Add(GetDirectory(subdir));
                    }
                }
                catch {; }
            }

            return info;
        }
        public void LoadElements(XElement xElem, TreeNode treeNode)
        {
            foreach (XElement element in xElem.Elements())
            {
                if (element.HasElements)
                {
                    if (element.FirstAttribute != null)
                    {
                        TreeNode tempNode = treeNode.Nodes.Add(element.FirstAttribute.Value);
                        LoadElements(element, tempNode);
                    }
                    else
                    {
                        LoadElements(element, treeNode);
                    }
                }
                else
                    treeNode.Nodes.Add(element.FirstAttribute.Value);
            }

        }
    }
}
