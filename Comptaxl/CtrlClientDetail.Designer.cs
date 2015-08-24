namespace Comptaxl
{
    partial class CtrlClientDetail
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label personNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlClientDetail));
            System.Windows.Forms.Label personFirstNameLabel;
            System.Windows.Forms.Label personSocialNameLabel;
            System.Windows.Forms.Label personAddressLabel;
            System.Windows.Forms.Label personZipCodeLabel;
            System.Windows.Forms.Label personCityLabel;
            System.Windows.Forms.Label personEmailLabel;
            System.Windows.Forms.Label clientBirthdateLabel;
            System.Windows.Forms.Label clientCommentaireLabel;
            this.personNameTextBox = new System.Windows.Forms.TextBox();
            this.c_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.personSocialNameTextBox = new System.Windows.Forms.TextBox();
            this.personAddressTextBox = new System.Windows.Forms.TextBox();
            this.personZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.personCityTextBox = new System.Windows.Forms.TextBox();
            this.personEmailTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clientCommentaireTextBox = new System.Windows.Forms.TextBox();
            this.clientBirthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cPhoneTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            personNameLabel = new System.Windows.Forms.Label();
            personFirstNameLabel = new System.Windows.Forms.Label();
            personSocialNameLabel = new System.Windows.Forms.Label();
            personAddressLabel = new System.Windows.Forms.Label();
            personZipCodeLabel = new System.Windows.Forms.Label();
            personCityLabel = new System.Windows.Forms.Label();
            personEmailLabel = new System.Windows.Forms.Label();
            clientBirthdateLabel = new System.Windows.Forms.Label();
            clientCommentaireLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c_ClientBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPhoneTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personNameLabel
            // 
            resources.ApplyResources(personNameLabel, "personNameLabel");
            personNameLabel.Name = "personNameLabel";
            // 
            // personFirstNameLabel
            // 
            resources.ApplyResources(personFirstNameLabel, "personFirstNameLabel");
            personFirstNameLabel.Name = "personFirstNameLabel";
            // 
            // personSocialNameLabel
            // 
            resources.ApplyResources(personSocialNameLabel, "personSocialNameLabel");
            personSocialNameLabel.Name = "personSocialNameLabel";
            // 
            // personAddressLabel
            // 
            resources.ApplyResources(personAddressLabel, "personAddressLabel");
            personAddressLabel.Name = "personAddressLabel";
            // 
            // personZipCodeLabel
            // 
            resources.ApplyResources(personZipCodeLabel, "personZipCodeLabel");
            personZipCodeLabel.Name = "personZipCodeLabel";
            // 
            // personCityLabel
            // 
            resources.ApplyResources(personCityLabel, "personCityLabel");
            personCityLabel.Name = "personCityLabel";
            // 
            // personEmailLabel
            // 
            resources.ApplyResources(personEmailLabel, "personEmailLabel");
            personEmailLabel.Name = "personEmailLabel";
            // 
            // clientBirthdateLabel
            // 
            resources.ApplyResources(clientBirthdateLabel, "clientBirthdateLabel");
            clientBirthdateLabel.Name = "clientBirthdateLabel";
            // 
            // clientCommentaireLabel
            // 
            resources.ApplyResources(clientCommentaireLabel, "clientCommentaireLabel");
            clientCommentaireLabel.Name = "clientCommentaireLabel";
            // 
            // personNameTextBox
            // 
            resources.ApplyResources(this.personNameTextBox, "personNameTextBox");
            this.personNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_ClientBindingSource, "PersonName", true));
            this.personNameTextBox.Name = "personNameTextBox";
            this.personNameTextBox.TextChanged += new System.EventHandler(this.personNameTextBox_TextChanged);
            // 
            // c_ClientBindingSource
            // 
            this.c_ClientBindingSource.DataSource = typeof(ComptaxlData.C_Client);
            // 
            // personFirstNameTextBox
            // 
            resources.ApplyResources(this.personFirstNameTextBox, "personFirstNameTextBox");
            this.personFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_ClientBindingSource, "PersonFirstName", true));
            this.personFirstNameTextBox.Name = "personFirstNameTextBox";
            // 
            // personSocialNameTextBox
            // 
            resources.ApplyResources(this.personSocialNameTextBox, "personSocialNameTextBox");
            this.personSocialNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_ClientBindingSource, "PersonSocialName", true));
            this.personSocialNameTextBox.Name = "personSocialNameTextBox";
            // 
            // personAddressTextBox
            // 
            this.personAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_ClientBindingSource, "PersonAddress", true));
            resources.ApplyResources(this.personAddressTextBox, "personAddressTextBox");
            this.personAddressTextBox.Name = "personAddressTextBox";
            // 
            // personZipCodeTextBox
            // 
            resources.ApplyResources(this.personZipCodeTextBox, "personZipCodeTextBox");
            this.personZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_ClientBindingSource, "PersonZipCode", true));
            this.personZipCodeTextBox.Name = "personZipCodeTextBox";
            // 
            // personCityTextBox
            // 
            resources.ApplyResources(this.personCityTextBox, "personCityTextBox");
            this.personCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_ClientBindingSource, "PersonCity", true));
            this.personCityTextBox.Name = "personCityTextBox";
            // 
            // personEmailTextBox
            // 
            resources.ApplyResources(this.personEmailTextBox, "personEmailTextBox");
            this.personEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_ClientBindingSource, "PersonEmail", true));
            this.personEmailTextBox.Name = "personEmailTextBox";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(clientCommentaireLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.clientCommentaireTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(clientBirthdateLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.clientBirthdateDateTimePicker, 1, 7);
            this.tableLayoutPanel1.Controls.Add(personSocialNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.personEmailTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(personEmailLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.personSocialNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(personNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.personCityTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(personCityLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.personNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(personFirstNameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.personZipCodeTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(personZipCodeLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.personFirstNameTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(personAddressLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.personAddressTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // clientCommentaireTextBox
            // 
            this.clientCommentaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_ClientBindingSource, "ClientCommentaire", true));
            resources.ApplyResources(this.clientCommentaireTextBox, "clientCommentaireTextBox");
            this.clientCommentaireTextBox.Name = "clientCommentaireTextBox";
            // 
            // clientBirthdateDateTimePicker
            // 
            resources.ApplyResources(this.clientBirthdateDateTimePicker, "clientBirthdateDateTimePicker");
            this.clientBirthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.c_ClientBindingSource, "ClientBirthdate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, new System.DateTime(1800, 1, 1, 0, 0, 0, 0)));
            this.clientBirthdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.clientBirthdateDateTimePicker.Name = "clientBirthdateDateTimePicker";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumberDataGridViewTextBoxColumn,
            this.phoneTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phoneListBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            resources.ApplyResources(this.phoneNumberDataGridViewTextBoxColumn, "phoneNumberDataGridViewTextBoxColumn");
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // phoneTypeDataGridViewTextBoxColumn
            // 
            this.phoneTypeDataGridViewTextBoxColumn.DataPropertyName = "PhoneType";
            this.phoneTypeDataGridViewTextBoxColumn.DataSource = this.cPhoneTypeBindingSource;
            resources.ApplyResources(this.phoneTypeDataGridViewTextBoxColumn, "phoneTypeDataGridViewTextBoxColumn");
            this.phoneTypeDataGridViewTextBoxColumn.Name = "phoneTypeDataGridViewTextBoxColumn";
            this.phoneTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.phoneTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.phoneTypeDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // cPhoneTypeBindingSource
            // 
            this.cPhoneTypeBindingSource.DataSource = typeof(ComptaxlData.C_PhoneType);
            // 
            // phoneListBindingSource
            // 
            this.phoneListBindingSource.DataMember = "PhoneList";
            this.phoneListBindingSource.DataSource = this.c_ClientBindingSource;
            // 
            // CtrlClientDetail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CtrlClientDetail";
            ((System.ComponentModel.ISupportInitialize)(this.c_ClientBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPhoneTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource c_ClientBindingSource;
        private System.Windows.Forms.TextBox personNameTextBox;
        private System.Windows.Forms.TextBox personFirstNameTextBox;
        private System.Windows.Forms.TextBox personSocialNameTextBox;
        private System.Windows.Forms.TextBox personAddressTextBox;
        private System.Windows.Forms.TextBox personZipCodeTextBox;
        private System.Windows.Forms.TextBox personCityTextBox;
        private System.Windows.Forms.TextBox personEmailTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox clientCommentaireTextBox;
        private System.Windows.Forms.DateTimePicker clientBirthdateDateTimePicker;
        private System.Windows.Forms.BindingSource cPhoneTypeBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource phoneListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn phoneTypeDataGridViewTextBoxColumn;
    }
}
