namespace Pika_Test_Framework
{
    partial class BaselineDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.pikaDBDataSet = new Pika_Test_Framework.PikaDBDataSet();
            this.baselinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baselinesTableAdapter = new Pika_Test_Framework.PikaDBDataSetTableAdapters.BaselinesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pikaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baselinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Baseline test data that you wish to load:";
            // 
            // pikaDBDataSet
            // 
            this.pikaDBDataSet.DataSetName = "PikaDBDataSet";
            this.pikaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(209, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Set as default baseline.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.baselinesBindingSource, "ID", true));
            this.comboBox1.DataSource = this.baselinesBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "ID";
            // 
            // BaselineDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 132);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "BaselineDialog";
            this.Text = "BaselineDialog";
            this.Load += new System.EventHandler(this.BaselineDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pikaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baselinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private PikaDBDataSet pikaDBDataSet;
        private System.Windows.Forms.BindingSource baselinesBindingSource;
        private PikaDBDataSetTableAdapters.BaselinesTableAdapter baselinesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}