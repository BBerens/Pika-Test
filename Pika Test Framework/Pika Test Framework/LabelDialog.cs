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
    public partial class LabelDialog : Form
    {
        public int weight { get; set; }
        public LabelDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            weight = trackBar1.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case (1):
                    {
                        
                        tracklbl1.Font = new Font(Font, FontStyle.Bold);
                        tracklbl1.ForeColor = Color.Blue;
                        tracklbl2.Font = new Font(Font, FontStyle.Regular);
                        tracklbl2.ForeColor = Color.Black;
                        tracklbl3.Font = new Font(Font, FontStyle.Regular);
                        tracklbl3.ForeColor = Color.Black;
                        tracklbl4.Font = new Font(Font, FontStyle.Regular);
                        tracklbl4.ForeColor = Color.Black;
                        tracklbl5.Font = new Font(Font, FontStyle.Regular);
                        tracklbl5.ForeColor = Color.Black;
                        break;
                    }
                case (2):
                    {
                        tracklbl2.Font = new Font(Font, FontStyle.Bold);
                        tracklbl2.ForeColor = Color.Violet;
                        tracklbl1.Font = new Font(Font, FontStyle.Regular);
                        tracklbl1.ForeColor = Color.Black;
                        tracklbl3.Font = new Font(Font, FontStyle.Regular);
                        tracklbl3.ForeColor = Color.Black;
                        tracklbl4.Font = new Font(Font, FontStyle.Regular);
                        tracklbl4.ForeColor = Color.Black;
                        tracklbl5.Font = new Font(Font, FontStyle.Regular);
                        tracklbl5.ForeColor = Color.Black;
                        break;
                    }
                case (3):
                    {
                        tracklbl3.Font = new Font(Font, FontStyle.Bold);
                        tracklbl3.ForeColor = Color.Purple;
                        tracklbl1.Font = new Font(Font, FontStyle.Regular);
                        tracklbl1.ForeColor = Color.Black;
                        tracklbl2.Font = new Font(Font, FontStyle.Regular);
                        tracklbl2.ForeColor = Color.Black;
                        tracklbl4.Font = new Font(Font, FontStyle.Regular);
                        tracklbl4.ForeColor = Color.Black;
                        tracklbl5.Font = new Font(Font, FontStyle.Regular);
                        tracklbl5.ForeColor = Color.Black;
                        break;
                    }
                case (4):
                    {
                        tracklbl4.Font = new Font(Font, FontStyle.Bold);
                        tracklbl4.ForeColor = Color.Crimson;
                        tracklbl1.Font = new Font(Font, FontStyle.Regular);
                        tracklbl1.ForeColor = Color.Black;
                        tracklbl2.Font = new Font(Font, FontStyle.Regular);
                        tracklbl2.ForeColor = Color.Black;
                        tracklbl3.Font = new Font(Font, FontStyle.Regular);
                        tracklbl3.ForeColor = Color.Black;
                        tracklbl5.Font = new Font(Font, FontStyle.Regular);
                        tracklbl5.ForeColor = Color.Black;
                        break;
                    }
                default:
                    {
                        tracklbl5.Font = new Font(Font, FontStyle.Bold);
                        tracklbl5.ForeColor = Color.Red;
                        tracklbl1.Font = new Font(Font, FontStyle.Regular);
                        tracklbl1.ForeColor = Color.Black;
                        tracklbl2.Font = new Font(Font, FontStyle.Regular);
                        tracklbl2.ForeColor = Color.Black;
                        tracklbl3.Font = new Font(Font, FontStyle.Regular);
                        tracklbl3.ForeColor = Color.Black;
                        tracklbl4.Font = new Font(Font, FontStyle.Regular);
                        tracklbl4.ForeColor = Color.Black;
                        break;
                    }
            }

        }
    }
}
