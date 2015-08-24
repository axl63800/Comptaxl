namespace Comptaxl
{
    partial class F_Clients
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
            this.cClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ctrlClientDetail1 = new CtrlClientDetail();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.phoneListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPhoneTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPhoneTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cClientBindingSource
            // 
            this.cClientBindingSource.DataSource = typeof(ComptaxlData.C_Client);
            this.cClientBindingSource.PositionChanged += new System.EventHandler(this.cClientBindingSource_PositionChanged);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.cClientBindingSource;
            this.listBox1.DisplayMember = "PersonFullName";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 426);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ctrlClientDetail1);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Size = new System.Drawing.Size(913, 426);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 1;
            // 
            // ctrlClientDetail1
            // 
            this.ctrlClientDetail1.ClientBindingSource = this.cClientBindingSource;
            this.ctrlClientDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlClientDetail1.Location = new System.Drawing.Point(0, 0);
            this.ctrlClientDetail1.Name = "ctrlClientDetail1";
            this.ctrlClientDetail1.PhoneTypeBindingSource = this.cPhoneTypeBindingSource;
            this.ctrlClientDetail1.Size = new System.Drawing.Size(605, 426);
            this.ctrlClientDetail1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(488, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Supprimer ce client";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ajouter un client";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // phoneListBindingSource
            // 
            this.phoneListBindingSource.DataMember = "PhoneList";
            this.phoneListBindingSource.DataSource = this.cClientBindingSource;
            // 
            // cPhoneTypeBindingSource
            // 
            this.cPhoneTypeBindingSource.DataSource = typeof(ComptaxlData.C_PhoneType);
            // 
            // F_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 489);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.splitContainer1);
            this.Name = "F_Clients";
            this.Text = "F_Clients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Clients_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cClientBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPhoneTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private CtrlClientDetail ctrlClientDetail1;
        internal System.Windows.Forms.BindingSource cClientBindingSource;
        private System.Windows.Forms.BindingSource phoneListBindingSource;
        internal System.Windows.Forms.BindingSource cPhoneTypeBindingSource;
    }
}