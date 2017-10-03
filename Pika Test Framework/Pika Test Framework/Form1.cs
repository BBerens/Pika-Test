using System;
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
                    //Fix this to properly use stored procedure
                    //testsTableAdapter.InsertTest(newTest.Name, newTest.Type, newTest.FileName, Encoding.UTF8.GetBytes(newTest.Description), newTest.DateCreated, newTest.DateModified, newTest.Baseline);
                    
                    foreach(Label label in newTest.labels)
                    {
                       //this.testLabelsTableAdapter1.InsertQuery(Convert.ToInt32(newTestID), label.LabelId, label.Weight);
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
                    }
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            BVSGetRequest("http://sc-css-wb-02-vm/dev/ka/bvskayakapi.php?action=get&id=418");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = true;
                textBox1.Enabled = true;
                comboBox1.DataSource = allColumns;
            }
            else
            {
                comboBox1.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                comboBox2.Enabled = true;
                textBox2.Enabled = true;
                comboBox2.DataSource = allColumns;
            }
            else
            {
                comboBox2.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                comboBox3.Enabled = true;
                textBox3.Enabled = true;
                comboBox3.DataSource = allColumns;
            }
            else
            {
                comboBox3.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                comboBox4.Enabled = true;
                textBox4.Enabled = true;
                comboBox4.DataSource = allColumns;
            }
            else
            {
                comboBox4.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                comboBox5.Enabled = true;
                textBox5.Enabled = true;
                comboBox5.DataSource = allColumns;
            }
            else
            {
                comboBox5.Enabled = false;
                textBox5.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestXMLParser testXMLParser = new TestXMLParser("C:\\Users\\bberens153719\\Source\\Repos\\Pika-Test\\Pika Test Framework\\PikaUpdater\\TestResultDAP.xml");
        }
    }
}
