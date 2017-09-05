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
        private Test newTest;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pikaDBDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.pikaDBDataSet.Tests);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var newTestForm = new NewTestForm())
            {
                var result = newTestForm.ShowDialog();
                if(result == DialogResult.OK)
                {
                    newTest = newTestForm.returnTest;
                    testsTableAdapter.InsertQuery(newTest.Name, newTest.Type, newTest.FileName, newTest.DateCreated, newTest.DateModified, Encoding.UTF8.GetBytes(newTest.Description));
                    testsTableAdapter.Update(pikaDBDataSet);
                    this.testsTableAdapter.Fill(this.pikaDBDataSet.Tests);
                    dataGridView1.Update();
                }
            }
                
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.testsTableAdapter.Fill(this.pikaDBDataSet.Tests);
        }

    }
}
