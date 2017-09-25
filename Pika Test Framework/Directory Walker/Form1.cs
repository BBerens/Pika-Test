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



namespace Directory_Walker
{
    public partial class Form1 : Form
    {
        string rootDirectory;
        private List<FileInfo> testFiles = new List<FileInfo>();

        public Form1()
        {
            InitializeComponent();
            
            this.baselinesTableAdapter.Fill(this.pikaDBDataSet.Baselines);
            this.kayakFilesTableAdapter.Fill(this.pikaDBDataSet.KayakFiles, 1);

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
            var doc = GetDirectory(dir, testFiles);
            TreeNode treeNode = treeView1.Nodes.Add("Root");
            LoadElements(doc, treeNode);
            doc.Save("dirStructure.xml");
            foreach(FileInfo file in testFiles)
            {
                PikaDBDataSet.KayakFilesDataTable filesDT = kayakFilesTableAdapter.GetDataByFileName(1, file.FullName);
                if (filesDT.Count == 0)
                    ; // New file -> Add
                else if (filesDT.Count == 1)
                    ; // File already exists in DB. Check if this is a newer copy
                else
                    ; // Something is wrong and more than one file in DB have the same filepath
            }
            listBox1.DataSource = testFiles;
            listBox1.DisplayMember = "FullName";
            listBox1.Update();
        }

        private static XElement GetDirectory(DirectoryInfo dir, List<FileInfo> testFiles)
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
                            new XAttribute("name", file.Name), new XAttribute("created", file.CreationTime.ToShortDateString()), new XAttribute("modified", file.LastWriteTime), new XAttribute("filepath", file.FullName)));
                        testFiles.Add(file);
                    }

                    foreach (var subdir in dir.GetDirectories())
                    {
                        info.Add(GetDirectory(subdir, testFiles));
                    }
                }
                catch {; }
            }

            return info;
        }
        private void LoadElements(XElement xElem, TreeNode treeNode)
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



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pikaDBDataSet.Baselines' table. You can move, or remove it, as needed.
            this.baselinesTableAdapter.Fill(this.pikaDBDataSet.Baselines);
            // TODO: This line of code loads data into the 'pikaDBDataSet.KayakFiles' table. You can move, or remove it, as needed.
            this.kayakFilesTableAdapter.Fill(this.pikaDBDataSet.KayakFiles, 1);

        }
    }
}
