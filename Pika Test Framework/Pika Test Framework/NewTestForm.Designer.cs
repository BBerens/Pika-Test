namespace Pika_Test_Framework
{
    partial class NewTestForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.dateCreatedTextBox = new System.Windows.Forms.TextBox();
            this.dateModifiedTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pikaDBDataSet = new Pika_Test_Framework.PikaDBDataSet();
            this.labelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelsTableAdapter = new Pika_Test_Framework.PikaDBDataSetTableAdapters.LabelsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.baselineCombo = new System.Windows.Forms.ComboBox();
            this.baselinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baselinesTableAdapter = new Pika_Test_Framework.PikaDBDataSetTableAdapters.BaselinesTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextieBox1 = new Pika_Test_Framework.RichTextieBox();
            this.baselinesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pikaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baselinesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baselinesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baseline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Filename";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Created";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date Modified";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Description";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(86, 56);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(86, 83);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(86, 115);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 11;
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(86, 147);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.filenameTextBox.TabIndex = 12;
            // 
            // dateCreatedTextBox
            // 
            this.dateCreatedTextBox.Location = new System.Drawing.Point(86, 182);
            this.dateCreatedTextBox.Name = "dateCreatedTextBox";
            this.dateCreatedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateCreatedTextBox.TabIndex = 13;
            // 
            // dateModifiedTextBox
            // 
            this.dateModifiedTextBox.Location = new System.Drawing.Point(86, 215);
            this.dateModifiedTextBox.Name = "dateModifiedTextBox";
            this.dateModifiedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateModifiedTextBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Labels";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pikaDBDataSet
            // 
            this.pikaDBDataSet.DataSetName = "PikaDBDataSet";
            this.pikaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelsBindingSource
            // 
            this.labelsBindingSource.DataMember = "Labels";
            this.labelsBindingSource.DataSource = this.pikaDBDataSet;
            // 
            // labelsTableAdapter
            // 
            this.labelsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.labelsBindingSource;
            this.comboBox1.DisplayMember = "LabelName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Add Label";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(203, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Remove Label";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // baselineCombo
            // 
            this.baselineCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pikaDBDataSet, "Baselines.ID", true));
            this.baselineCombo.FormattingEnabled = true;
            this.baselineCombo.Location = new System.Drawing.Point(65, 29);
            this.baselineCombo.Name = "baselineCombo";
            this.baselineCombo.Size = new System.Drawing.Size(121, 21);
            this.baselineCombo.TabIndex = 24;
            // 
            // baselinesBindingSource
            // 
            this.baselinesBindingSource.DataMember = "Baselines";
            this.baselinesBindingSource.DataSource = this.pikaDBDataSet;
            // 
            // baselinesTableAdapter
            // 
            this.baselinesTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(197, 549);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 537);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.baselineCombo);
            this.panel1.Controls.Add(this.richTextieBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dateModifiedTextBox);
            this.panel1.Controls.Add(this.dateCreatedTextBox);
            this.panel1.Controls.Add(this.filenameTextBox);
            this.panel1.Controls.Add(this.typeTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 506);
            this.panel1.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(65, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Edit Label";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(65, 279);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(213, 150);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Label";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Weight";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // richTextieBox1
            // 
            this.richTextieBox1.Location = new System.Drawing.Point(355, 29);
            this.richTextieBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.richTextieBox1.Name = "richTextieBox1";
            this.richTextieBox1.Size = new System.Drawing.Size(469, 480);
            this.richTextieBox1.TabIndex = 23;
            // 
            // baselinesBindingSource1
            // 
            this.baselinesBindingSource1.DataMember = "Baselines";
            this.baselinesBindingSource1.DataSource = this.pikaDBDataSet;
            // 
            // NewTestForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(727, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Name = "NewTestForm";
            this.Text = "NewTestForm";
            this.Load += new System.EventHandler(this.NewTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pikaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baselinesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baselinesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.TextBox dateCreatedTextBox;
        private System.Windows.Forms.TextBox dateModifiedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private PikaDBDataSet pikaDBDataSet;
        private System.Windows.Forms.BindingSource labelsBindingSource;
        private PikaDBDataSetTableAdapters.LabelsTableAdapter labelsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private RichTextieBox richTextieBox1;
        private System.Windows.Forms.ComboBox baselineCombo;
        private System.Windows.Forms.BindingSource baselinesBindingSource;
        private PikaDBDataSetTableAdapters.BaselinesTableAdapter baselinesTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource baselinesBindingSource1;
    }
}