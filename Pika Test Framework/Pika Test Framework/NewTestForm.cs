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
        
        public NewTestForm(PikaDBDataSet.BaselinesDataTable baselinesDT, PikaDBDataSet.LabelsDataTable labelsDT, int baseline)
        {
            InitializeComponent();
            groupBox1.Text = "";
            baselineCombo.DataSource = baselinesDT;
            baselineCombo.DisplayMember = "Name";
            baselineCombo.ValueMember = "Id";
            baselineCombo.SelectedIndex = baseline + 1;
        }

        public NewTestForm(PikaDBDataSet.BaselinesDataTable baselinesDT, PikaDBDataSet.LabelsDataTable labelsDT, Test modifiedTest)
        {
            InitializeComponent();
            baselineCombo.DataSource = baselinesDT;
            baselineCombo.DisplayMember = "Name";
            baselineCombo.ValueMember = "Id";
            idTextBox.Text = modifiedTest.TestId;
            idTextBox.Enabled = false;
            nameTextBox.Text = modifiedTest.Name;
            //nameTextBox.Enabled = true;
            groupBox1.Text = modifiedTest.TestId;
            typeTextBox.Text = modifiedTest.Type;
            labelList = new BindingList<Label>(modifiedTest.labels);
            foreach(Label label in modifiedTest.labels)
                labelHashSet.Add(label.LabelId);
            filenameTextBox.Text = modifiedTest.FileName;
            dateCreatedTextBox.Text = modifiedTest.DateCreated.ToLongTimeString();
            dateModifiedTextBox.Text = modifiedTest.DateModified.ToLongTimeString();
            richTextieBox1.Text = modifiedTest.Description;
        }
        private void NewTestForm_Load(object sender, EventArgs e)
        {
            // Trying to minimize the fill commands.
            // TODO: This line of code loads data into the 'pikaDBDataSet.Baselines' table. You can move, or remove it, as needed.
            //this.baselinesTableAdapter.Fill(this.pikaDBDataSet.Baselines);
            // TODO: This line of code loads data into the 'pikaDBDataSet.Labels' table. You can move, or remove it, as needed.
            //this.labelsTableAdapter.Fill(this.pikaDBDataSet.Labels);

            dataGridView1.DataSource = labelList;
            dataGridView1.Columns[0].DataPropertyName = "Name";
            dataGridView1.Columns[1].DataPropertyName = "Weight";
            dateCreatedTextBox.Text = DateTime.Now.ToShortDateString();
            dateModifiedTextBox.Text = DateTime.Now.ToShortDateString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (var labelDialog = new LabelDialog())
            {
                var result = labelDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                    Label newLabel = new Label();
                    newLabel.LabelId = (int)drv["labelId"];
                    newLabel.Name = (string)drv["labelName"];
                    newLabel.Weight = labelDialog.weight;
                    if (labelHashSet.Add(newLabel.LabelId))
                        labelList.Add(newLabel);
                    dataGridView1.Update();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            labelHashSet.Remove(((Label)dataGridView1.SelectedRows[0].DataBoundItem).LabelId);
            labelList.Remove((Label)dataGridView1.SelectedRows[0].DataBoundItem);
            dataGridView1.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test newTest = new Test();
            newTest.Name = nameTextBox.Text;
            newTest.Baseline = (int)baselineCombo.SelectedValue;
            newTest.Type = typeTextBox.Text;
            newTest.FileName = filenameTextBox.Text;
            newTest.DateCreated = Convert.ToDateTime(dateCreatedTextBox.Text);
            newTest.DateModified = Convert.ToDateTime(dateModifiedTextBox.Text);
            newTest.Description = richTextieBox1.Text;
            newTest.labels = labelList.ToList<Label>();

            this.returnTest = newTest;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
        void OnCollectionChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Height = this.dataGridView1.PreferredSize.Height;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.button3.Enabled = true;
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if(this.dataGridView1.Rows.Count == 0)
            {
                this.button3.Enabled = false;
            }

        }
    }
}
