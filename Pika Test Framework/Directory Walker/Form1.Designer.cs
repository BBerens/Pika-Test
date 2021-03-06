﻿namespace Directory_Walker
{
    partial class Form1
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pikaDBDataSet = new Directory_Walker.PikaDBDataSet();
            this.kayakFilesTableAdapter = new Directory_Walker.PikaDBDataSetTableAdapters.KayakFilesTableAdapter();
            this.tableAdapterManager = new Directory_Walker.PikaDBDataSetTableAdapters.TableAdapterManager();
            this.baselinesTableAdapter = new Directory_Walker.PikaDBDataSetTableAdapters.BaselinesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pikaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(43, 51);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select Root Directory";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(159, 100);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(273, 417);
            this.treeView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate Tree";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(506, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 459);
            this.listBox1.TabIndex = 4;
            // 
            // pikaDBDataSet
            // 
            this.pikaDBDataSet.DataSetName = "PikaDBDataSet";
            this.pikaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayakFilesTableAdapter
            // 
            this.kayakFilesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaselinesTableAdapter = this.baselinesTableAdapter;
            this.tableAdapterManager.KayakFilesTableAdapter = this.kayakFilesTableAdapter;
            this.tableAdapterManager.LabelsTableAdapter = null;
            this.tableAdapterManager.ResourcesTableAdapter = null;
            this.tableAdapterManager.RunsTableAdapter = null;
            this.tableAdapterManager.TestLabelsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Directory_Walker.PikaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // baselinesTableAdapter
            // 
            this.baselinesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 618);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pikaDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private PikaDBDataSet pikaDBDataSet;
        private PikaDBDataSetTableAdapters.KayakFilesTableAdapter kayakFilesTableAdapter;
        private PikaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PikaDBDataSetTableAdapters.BaselinesTableAdapter baselinesTableAdapter;
    }
}

