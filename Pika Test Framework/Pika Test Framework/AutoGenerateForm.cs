using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pika_Test_Framework;

namespace Pika_Test_Framework
{
    public partial class AutoGenerateForm : Form
    {
        
        public AutoGenerateForm(PikaDBDataSet pikaDBDataSet)
        {
            InitializeComponent();
            PikaDBDataSet.KayakFilesDataTable newKayakFiles;
            comboBox1.DataSource = pikaDBDataSet.Baselines;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "FolderPath";
            textBox1.Text = (string)comboBox1.SelectedValue;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.SelectedPath = textBox1.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = (string)comboBox1.SelectedValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoGenerator autoGen = new AutoGenerator(folderBrowserDialog1.SelectedPath);
        }
    }
}
