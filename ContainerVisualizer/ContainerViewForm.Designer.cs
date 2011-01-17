using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace ContainerVisualizer
{
    partial class ContainerViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainerViewForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.displayRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filetStringTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Implementation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayRegistrationBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Interface,
            this.Implementation});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 20);
            this.dataGridView1.DataSource = this.displayRegistrationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(740, 363);
            this.dataGridView1.TabIndex = 1;
            // 
            // filetStringTextBox
            // 
            this.filetStringTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filetStringTextBox.Location = new System.Drawing.Point(103, 3);
            this.filetStringTextBox.Name = "filetStringTextBox";
            this.filetStringTextBox.Size = new System.Drawing.Size(194, 23);
            this.filetStringTextBox.TabIndex = 2;
            this.filetStringTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Right;
            this.label.Location = new System.Drawing.Point(11, 0);
            this.label.MinimumSize = new System.Drawing.Size(65, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 30);
            this.label.TabIndex = 3;
            this.label.Text = "Search For :";
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearFilterButton.Location = new System.Drawing.Point(303, 3);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(94, 24);
            this.clearFilterButton.TabIndex = 4;
            this.clearFilterButton.Text = "Clear Filter";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearFilterButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.filetStringTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 401);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.FillWeight = 200F;
            this.Name.HeaderText = "Registered Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Interface
            // 
            this.Interface.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Interface.DataPropertyName = "InterfaceName";
            this.Interface.FillWeight = 200F;
            this.Interface.HeaderText = "Interface";
            this.Interface.Name = "Interface";
            this.Interface.ReadOnly = true;
            // 
            // Implementation
            // 
            this.Implementation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Implementation.DataPropertyName = "ImplementationName";
            this.Implementation.FillWeight = 200F;
            this.Implementation.HeaderText = "Implementation";
            this.Implementation.Name = "Implementation";
            this.Implementation.ReadOnly = true;
            // 
            // ContainerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "ContainerViewForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Windsor Container Debugger Visualizer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ContainerViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayRegistrationBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource displayRegistrationBindingSource;
        private TextBox filetStringTextBox;
        private Label label;
        private Button clearFilterButton;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn interfaceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn implementationnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Interface;
        private DataGridViewTextBoxColumn Implementation;
    }
}