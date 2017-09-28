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
    public partial class BaselineDialog : Form
    {
        public int selectedBaseline { get; set; }
        public bool setDefault { get; set; }


        public BaselineDialog()
        {
            InitializeComponent();
        }

        private void BaselineDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pikaDBDataSet.Baselines' table. You can move, or remove it, as needed.
            this.baselinesTableAdapter.Fill(this.pikaDBDataSet.Baselines);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedBaseline = (int)comboBox1.SelectedValue;
            setDefault = checkBox1.Checked;
            this.DialogResult = DialogResult.OK;
        }
    }
}
