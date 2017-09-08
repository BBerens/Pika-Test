namespace Pika_Test_Framework
{
    partial class LabelDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tracklbl1 = new System.Windows.Forms.Label();
            this.tracklbl3 = new System.Windows.Forms.Label();
            this.tracklbl5 = new System.Windows.Forms.Label();
            this.tracklbl2 = new System.Windows.Forms.Label();
            this.tracklbl4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a test weight for the label:";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(35, 36);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(231, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 3;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(44, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Accept";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(191, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tracklbl1
            // 
            this.tracklbl1.AutoSize = true;
            this.tracklbl1.Location = new System.Drawing.Point(24, 67);
            this.tracklbl1.Name = "tracklbl1";
            this.tracklbl1.Size = new System.Drawing.Size(50, 13);
            this.tracklbl1.TabIndex = 4;
            this.tracklbl1.Text = "1 - Trivial";
            // 
            // tracklbl3
            // 
            this.tracklbl3.AutoSize = true;
            this.tracklbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracklbl3.ForeColor = System.Drawing.Color.Blue;
            this.tracklbl3.Location = new System.Drawing.Point(121, 67);
            this.tracklbl3.Name = "tracklbl3";
            this.tracklbl3.Size = new System.Drawing.Size(62, 13);
            this.tracklbl3.TabIndex = 5;
            this.tracklbl3.Text = "3 - Useful";
            // 
            // tracklbl5
            // 
            this.tracklbl5.AutoSize = true;
            this.tracklbl5.Location = new System.Drawing.Point(232, 67);
            this.tracklbl5.Name = "tracklbl5";
            this.tracklbl5.Size = new System.Drawing.Size(42, 13);
            this.tracklbl5.TabIndex = 6;
            this.tracklbl5.Text = "5 - Vital";
            // 
            // tracklbl2
            // 
            this.tracklbl2.AutoSize = true;
            this.tracklbl2.Location = new System.Drawing.Point(93, 67);
            this.tracklbl2.Name = "tracklbl2";
            this.tracklbl2.Size = new System.Drawing.Size(13, 13);
            this.tracklbl2.TabIndex = 7;
            this.tracklbl2.Text = "2";
            // 
            // tracklbl4
            // 
            this.tracklbl4.AutoSize = true;
            this.tracklbl4.Location = new System.Drawing.Point(194, 67);
            this.tracklbl4.Name = "tracklbl4";
            this.tracklbl4.Size = new System.Drawing.Size(13, 13);
            this.tracklbl4.TabIndex = 8;
            this.tracklbl4.Text = "4";
            // 
            // LabelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 162);
            this.Controls.Add(this.tracklbl4);
            this.Controls.Add(this.tracklbl2);
            this.Controls.Add(this.tracklbl5);
            this.Controls.Add(this.tracklbl3);
            this.Controls.Add(this.tracklbl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Name = "LabelDialog";
            this.Text = "Select a Weight";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tracklbl1;
        private System.Windows.Forms.Label tracklbl3;
        private System.Windows.Forms.Label tracklbl5;
        private System.Windows.Forms.Label tracklbl2;
        private System.Windows.Forms.Label tracklbl4;
    }
}