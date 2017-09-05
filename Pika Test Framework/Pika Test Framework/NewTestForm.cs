using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pika_Test_Framework
{
    public partial class NewTestForm : Form
    {
        private BindingList<Label> labelList = new BindingList<Label>();
        private HashSet<int> labelHashSet = new HashSet<int>();
        public Test returnTest { get; set; }
        public NewTestForm()
        {
            InitializeComponent();
        }

        private void NewTestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pikaDBDataSet.Baselines' table. You can move, or remove it, as needed.
            this.baselinesTableAdapter.Fill(this.pikaDBDataSet.Baselines);
            // TODO: This line of code loads data into the 'pikaDBDataSet.Labels' table. You can move, or remove it, as needed.
            this.labelsTableAdapter.Fill(this.pikaDBDataSet.Labels);
            
            listBox1.DataSource = labelList;
            textBox6.Text = DateTime.Now.ToShortDateString();
            textBox7.Text = DateTime.Now.ToShortDateString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)comboBox1.SelectedItem;
            Label newLabel = new Label();
            newLabel.LabelId = (int)drv["labelId"];
            newLabel.Name = (string)drv["labelName"];
            if(labelHashSet.Add(newLabel.LabelId))
                labelList.Add(newLabel);
            listBox1.DisplayMember = "name";
           
            listBox1.Refresh();
            listBox1.Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelHashSet.Remove(((Label)listBox1.SelectedItem).LabelId);
            labelList.Remove((Label)listBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test newTest = new Test();
            newTest.Name = textBox3.Text;
            newTest.Baseline = (int)comboBox2.SelectedValue;
            newTest.Type = textBox4.Text;
            newTest.FileName = textBox5.Text;
            newTest.DateCreated = Convert.ToDateTime(textBox6.Text);
            newTest.DateModified = Convert.ToDateTime(textBox7.Text);
            newTest.Description = richTextieBox1.Text;

            this.returnTest = newTest;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
