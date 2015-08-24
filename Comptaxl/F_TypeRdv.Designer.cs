namespace Comptaxl
{
    partial class F_TypeRdv
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
            this.c_RdvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_TypeRdvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_TypeRdvDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.c_RdvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_TypeRdvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_TypeRdvDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // c_RdvBindingSource
            // 
            this.c_RdvBindingSource.DataSource = typeof(ComptaxlData.C_Rdv);
            // 
            // c_TypeRdvBindingSource
            // 
            this.c_TypeRdvBindingSource.DataSource = typeof(ComptaxlData.C_TypeRdv);
            // 
            // c_TypeRdvDataGridView
            // 
            this.c_TypeRdvDataGridView.AutoGenerateColumns = false;
            this.c_TypeRdvDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.c_TypeRdvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_TypeRdvDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.c_TypeRdvDataGridView.DataSource = this.c_TypeRdvBindingSource;
            this.c_TypeRdvDataGridView.Location = new System.Drawing.Point(12, 12);
            this.c_TypeRdvDataGridView.Name = "c_TypeRdvDataGridView";
            this.c_TypeRdvDataGridView.RowTemplate.Height = 24;
            this.c_TypeRdvDataGridView.Size = new System.Drawing.Size(817, 430);
            this.c_TypeRdvDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TypeRdvDesign";
            this.dataGridViewTextBoxColumn1.HeaderText = "TypeRdvDesign";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // F_TypeRdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 454);
            this.Controls.Add(this.c_TypeRdvDataGridView);
            this.Name = "F_TypeRdv";
            this.Text = "F_TypeRdv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_TypeRdv_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.c_RdvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_TypeRdvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_TypeRdvDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource c_RdvBindingSource;
        private System.Windows.Forms.BindingSource c_TypeRdvBindingSource;
        private System.Windows.Forms.DataGridView c_TypeRdvDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}