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
    public partial class Form1 : Form
    {
        int preferredBaseline;
        private Test newTest;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pikaDBDataSet.Tests' table. You can move, or remove it, as needed.
            this.baselinesTableAdapter1.Fill(this.pikaDBDataSet.Baselines);
            //myUserSettings = new UserSettings();
            

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
            this.testsTableAdapter.Fill(this.pikaDBDataSet.Tests, preferredBaseline);
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
                    pikaDBDataSet.Tests.AddTestsRow(newTest.Name, newTest.Type, newTest.FileName, newTest.DateCreated, newTest.DateModified, pikaDBDataSet.Baselines[newTest.Baseline], Encoding.UTF8.GetBytes(newTest.Description), newTest.TestId);
                    var newTestID = testsTableAdapter.InsertQuery(newTest.Name, newTest.Type, newTest.Baseline, newTest.FileName, newTest.DateCreated, newTest.DateModified, Encoding.UTF8.GetBytes(newTest.Description));
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
            
            int testId = (int)dataGridView1.SelectedCells[0].Value;
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
                        testsTableAdapter.InsertQuery(newTest.Name, newTest.Type, newTest.Baseline, newTest.FileName, newTest.DateCreated, newTest.DateModified, Encoding.UTF8.GetBytes(newTest.Description));
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
        }
    }
}
