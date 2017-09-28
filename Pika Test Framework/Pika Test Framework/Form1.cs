﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Pika_Test_Framework
{
    public partial class Form1 : Form
    {
        int preferredBaseline;
        private Test newTest;
        private List<string> allColumns = new List<string>();
        public Form1()
        {
            InitializeComponent();
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.baselinesTableAdapter1.Fill(this.pikaDBDataSet.Baselines);
            ;
            if (Properties.Settings.Default.Baseline == -1)
            {
                using (var bDlg = new BaselineDialog())
                {
                    var result = bDlg.ShowDialog();
                    if (bDlg.DialogResult == DialogResult.OK)
                    {
                        preferredBaseline = bDlg.selectedBaseline;
                        if(bDlg.setDefault)
                        {
                            Properties.Settings.Default.Baseline = preferredBaseline;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
            }
            else
            {
                preferredBaseline = Properties.Settings.Default.Baseline;
            }
            testsTableAdapter.Fill(this.pikaDBDataSet.Tests, preferredBaseline);
            dataGridView1.Update();
            
            foreach(DataTable dt in pikaDBDataSet.Tables)
            {
                if(dt.TableName == "Tests" || dt.TableName == "Runs" || dt.TableName == "Labels")
                foreach(DataColumn column in dt.Columns)
                {
                    allColumns.Add(dt.TableName +  "_" + column.ColumnName);
                }
            }

            comboBox1.DataSource = allColumns;
            comboBox2.DataSource = allColumns;
            comboBox3.DataSource = allColumns;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var newTestForm = new NewTestForm(pikaDBDataSet.Baselines, pikaDBDataSet.Labels, preferredBaseline))
            {
                var result = newTestForm.ShowDialog();
                if(result == DialogResult.OK)
                {
                    //int newTestID;
                    newTest = newTestForm.returnTest;
                    
                    pikaDBDataSet.Tests.AddTestsRow(newTest.TestId, newTest.Name, newTest.Type, newTest.FileName, Encoding.UTF8.GetBytes(newTest.Description), newTest.DateCreated, newTest.DateModified, pikaDBDataSet.Baselines[newTest.Baseline]);
                    var newTestID = testsTableAdapter.InsertQuery(newTest.TestId, newTest.Name, newTest.Type, newTest.FileName, Encoding.UTF8.GetBytes(newTest.Description), newTest.DateCreated, newTest.DateModified, newTest.Baseline);
                    //testsTableAdapter.Update(pikaDBDataSet);
                    foreach(Label label in newTest.labels)
                    {
                       this.testLabelsTableAdapter1.InsertQuery(Convert.ToInt32(newTestID), label.LabelId, label.Weight);
                    }
                    //this.testsTableAdapter.Fill(this.pikaDBDataSet.Tests, preferredBaseline);
                    dataGridView1.Update();
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int testId = (int)pikaDBDataSet.Tests.Rows[dataGridView1.SelectedRows[0].Index]["ID"];
            PikaDBDataSet.TestViewDataTable testRows = this.testViewTableAdapter1.GetDataByTestID(testId);
            Test modifiedTest = new Test(testRows);
            using (var newTestForm = new NewTestForm(pikaDBDataSet.Baselines, pikaDBDataSet.Labels, modifiedTest))
            {
                if (newTestForm.ShowDialog() == DialogResult.OK)
                {
                    newTest = newTestForm.returnTest;
                    if (newTest.TestId != "")
                    {

                    }
                    else
                    {
                        testsTableAdapter.InsertQuery(newTest.TestId, newTest.Name, newTest.Type, newTest.FileName, Encoding.UTF8.GetBytes(newTest.Description), newTest.DateCreated, newTest.DateModified, newTest.Baseline);
                        testsTableAdapter.Update(pikaDBDataSet);
                        this.testsTableAdapter.Fill(this.pikaDBDataSet.Tests, preferredBaseline);
                        dataGridView1.Update();
                    }
                }
            }
        }

        private int getBaselineSetting()
        {
            return -1; // unable to get preferred baseline
        }

        private void selectBaselineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var bDlg = new BaselineDialog())
            {
                var result = bDlg.ShowDialog();
                if (bDlg.DialogResult == DialogResult.OK)
                {
                    preferredBaseline = bDlg.selectedBaseline;
                    if (bDlg.setDefault)
                    {
                        Properties.Settings.Default.Baseline = preferredBaseline;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            testsTableAdapter.Fill(pikaDBDataSet.Tests, preferredBaseline);
            dataGridView1.Update();
        }

        private void autoGenerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoGenerateForm autoGen1 = new AutoGenerateForm(pikaDBDataSet, preferredBaseline);
            autoGen1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BVSGetRequest("http://sc-css-wb-02-vm/dev/ka/bvskayakapi.php?action=get&id=418");
            
        }

        async static void BVSGetRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string responseString = await content.ReadAsStringAsync();
                        Console.WriteLine(responseString);
                        ;
                    }
                }
            }
        }
    }
}
