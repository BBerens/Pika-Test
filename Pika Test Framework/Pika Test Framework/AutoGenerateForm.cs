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
using System.IO;

namespace Pika_Test_Framework
{
    public partial class AutoGenerateForm : Form
    {
        private int defaultBaseline;
        

        public AutoGenerateForm(PikaDBDataSet inPikaDBDataSet, int preferredBaseline)
        {
            defaultBaseline = preferredBaseline;
            pikaDBDataSet = inPikaDBDataSet;

            InitializeComponent();
            //PikaDBDataSetTableAdapters.KayakFilesTableAdapter kayakFilesTableAdapter = new PikaDBDataSetTableAdapters.KayakFilesTableAdapter();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "FolderPath";
            comboBox1.DataSource = pikaDBDataSet.Baselines;

            comboBox1.SelectedIndex = defaultBaseline;
            textBox1.Text = (string)comboBox1.SelectedValue;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.SelectedPath = textBox1.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = (string)comboBox1.SelectedValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoGenerator autoGen = new AutoGenerator(textBox1.Text, pikaDBDataSet);
            autoGen.FindNewTestFiles(pikaDBDataSet.NewKayakFileTable, comboBox1.SelectedIndex + 1);
            dataGridView1.DataSource = pikaDBDataSet.NewKayakFileTable;
            dataGridView1.Update();

        }

        private void kayakFilesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kayakFilesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pikaDBDataSet);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell CheckCell = new DataGridViewCheckBoxCell();
                CheckCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0];
                if ((bool)CheckCell.Value)
                {
                    dataGridView1.Rows[e.RowIndex].Selected = false;
                    CheckCell.Value = false;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Window;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    CheckCell.Value = true;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Highlight;
                }
            }

            else if(e.ColumnIndex == 1) // Clicked the Edit column icon
            {
                using (var newTestForm = new NewTestForm(pikaDBDataSet.Baselines, pikaDBDataSet.Labels, defaultBaseline, (PikaDBDataSet.NewKayakFileTableRow)pikaDBDataSet.NewKayakFileTable.Rows[e.RowIndex]))
                {
                    var result = newTestForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //int newTestID;
                        Test newTest = newTestForm.returnTest;
                        pikaDBDataSet.Tests.AddTestsRow(newTest.TestId, newTest.Name, newTest.Type, newTest.FileName, Encoding.UTF8.GetBytes(newTest.Description), newTest.DateCreated, newTest.DateModified, pikaDBDataSet.Baselines[newTest.Baseline]);
                        var newTestID = testsTableAdapter.InsertQuery(newTest.TestId, newTest.Name, newTest.Type, newTest.FileName, Encoding.UTF8.GetBytes(newTest.Description), newTest.DateCreated, newTest.DateModified, newTest.Baseline);
                        //testsTableAdapter.Update(pikaDBDataSet);
                        foreach (Label label in newTest.labels)
                        {
                            this.testLabelsTableAdapter.InsertQuery(Convert.ToInt32(newTestID), label.LabelId, label.Weight);
                        }
                        kayakFilesTableAdapter.Insert(newTest.Baseline, newTest.FileName, newTest.DateModified, newTest.DateCreated);
                        pikaDBDataSet.NewKayakFileTable.Rows[e.RowIndex].Delete();
                        //this.testsTableAdapter.Fill(this.pikaDBDataSet.Tests, preferredBaseline);
                        dataGridView1.Update();
                    }
                }
                
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["CheckColumn"].Value = false;
            }
            dataGridView1.Columns[0].HeaderCell.Value = false;
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                DataGridViewCheckBoxCell CheckCell = new DataGridViewCheckBoxCell();
                CheckCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0];
                if ((bool)CheckCell.Value)
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Highlight;
                else
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Window;
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                ImageCell = (DataGridViewImageCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                ImageCell.Value = Properties.Resources.Edit_16x;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                ImageCell = (DataGridViewImageCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                ImageCell.Value = Properties.Resources.Edit_grey_16x;
            }
        }


    }
}
