using System;
namespace Comptaxl
{
    partial class F_Rdv
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_RdvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTypeRdvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdvDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeRdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rdvAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReloadListPatient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPaymentsPending = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_RdvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTypeRdvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cClientBindingSource;
            this.comboBox1.DisplayMember = "PersonFullName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // cClientBindingSource
            // 
            this.cClientBindingSource.DataSource = typeof(ComptaxlData.C_Client);
            // 
            // c_RdvBindingSource
            // 
            this.c_RdvBindingSource.DataSource = typeof(ComptaxlData.C_Rdv);
            this.c_RdvBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.c_RdvBindingSource_AddingNew);
            this.c_RdvBindingSource.CurrentChanged += new System.EventHandler(this.c_RdvBindingSource_CurrentChanged);
            this.c_RdvBindingSource.PositionChanged += new System.EventHandler(this.c_RdvBindingSource_PositionChanged);
            // 
            // cTypeRdvBindingSource
            // 
            this.cTypeRdvBindingSource.DataSource = typeof(ComptaxlData.C_TypeRdv);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonDataGridViewTextBoxColumn,
            this.rdvDateTimeDataGridViewTextBoxColumn,
            this.idTypeRdvDataGridViewTextBoxColumn,
            this.rdvAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.c_RdvBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(655, 188);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // idPersonDataGridViewTextBoxColumn
            // 
            this.idPersonDataGridViewTextBoxColumn.DataPropertyName = "IdPerson";
            this.idPersonDataGridViewTextBoxColumn.HeaderText = "IdPerson";
            this.idPersonDataGridViewTextBoxColumn.Name = "idPersonDataGridViewTextBoxColumn";
            // 
            // rdvDateTimeDataGridViewTextBoxColumn
            // 
            this.rdvDateTimeDataGridViewTextBoxColumn.DataPropertyName = "RdvDateTime";
            this.rdvDateTimeDataGridViewTextBoxColumn.HeaderText = "RdvDateTime";
            this.rdvDateTimeDataGridViewTextBoxColumn.Name = "rdvDateTimeDataGridViewTextBoxColumn";
            // 
            // idTypeRdvDataGridViewTextBoxColumn
            // 
            this.idTypeRdvDataGridViewTextBoxColumn.DataPropertyName = "IdTypeRdv";
            this.idTypeRdvDataGridViewTextBoxColumn.DataSource = this.cTypeRdvBindingSource;
            this.idTypeRdvDataGridViewTextBoxColumn.DisplayMember = "TypeRdvDesign";
            this.idTypeRdvDataGridViewTextBoxColumn.HeaderText = "IdTypeRdv";
            this.idTypeRdvDataGridViewTextBoxColumn.Name = "idTypeRdvDataGridViewTextBoxColumn";
            this.idTypeRdvDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTypeRdvDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idTypeRdvDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // rdvAmountDataGridViewTextBoxColumn
            // 
            this.rdvAmountDataGridViewTextBoxColumn.DataPropertyName = "RdvAmount";
            this.rdvAmountDataGridViewTextBoxColumn.HeaderText = "RdvAmount";
            this.rdvAmountDataGridViewTextBoxColumn.Name = "rdvAmountDataGridViewTextBoxColumn";
            // 
            // btnReloadListPatient
            // 
            this.btnReloadListPatient.BackgroundImage = global::Comptaxl.Properties.Resources.reload;
            this.btnReloadListPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReloadListPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadListPatient.Location = new System.Drawing.Point(486, 17);
            this.btnReloadListPatient.Name = "btnReloadListPatient";
            this.btnReloadListPatient.Size = new System.Drawing.Size(47, 34);
            this.btnReloadListPatient.TabIndex = 7;
            this.btnReloadListPatient.UseVisualStyleBackColor = true;
            this.btnReloadListPatient.Click += new System.EventHandler(this.btnReloadListPatient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Voir Facture";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Facturer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblPaymentsPending
            // 
            this.lblPaymentsPending.AutoSize = true;
            this.lblPaymentsPending.Location = new System.Drawing.Point(57, 80);
            this.lblPaymentsPending.Name = "lblPaymentsPending";
            this.lblPaymentsPending.Size = new System.Drawing.Size(0, 17);
            this.lblPaymentsPending.TabIndex = 10;
            // 
            // F_Rdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 466);
            this.Controls.Add(this.lblPaymentsPending);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReloadListPatient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "F_Rdv";
            this.Text = "F_Rdv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Rdv_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_RdvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTypeRdvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cClientBindingSource;
        private System.Windows.Forms.BindingSource c_RdvBindingSource;
        private System.Windows.Forms.BindingSource cTypeRdvBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReloadListPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdvDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idTypeRdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdvAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPaymentsPending;
    }
}