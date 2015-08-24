namespace Comptaxl
{
    partial class F_UserConfig
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
            System.Windows.Forms.Label personNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_UserConfig));
            System.Windows.Forms.Label personFirstNameLabel;
            System.Windows.Forms.Label personAddressLabel;
            System.Windows.Forms.Label personZipCodeLabel;
            System.Windows.Forms.Label personCityLabel;
            System.Windows.Forms.Label personSocialNameLabel;
            System.Windows.Forms.Label userSiretNumberLabel;
            System.Windows.Forms.Label userFunctionLabel;
            System.Windows.Forms.Label personEmailLabel;
            this.c_UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cPhoneTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSiretNumberTextBox = new System.Windows.Forms.TextBox();
            this.personSocialNameTextBox = new System.Windows.Forms.TextBox();
            this.personEmailTextBox = new System.Windows.Forms.TextBox();
            this.personCityTextBox = new System.Windows.Forms.TextBox();
            this.personZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.personAddressTextBox = new System.Windows.Forms.TextBox();
            this.personNameTextBox = new System.Windows.Forms.TextBox();
            this.personFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.userFunctionTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            personNameLabel = new System.Windows.Forms.Label();
            personFirstNameLabel = new System.Windows.Forms.Label();
            personAddressLabel = new System.Windows.Forms.Label();
            personZipCodeLabel = new System.Windows.Forms.Label();
            personCityLabel = new System.Windows.Forms.Label();
            personSocialNameLabel = new System.Windows.Forms.Label();
            userSiretNumberLabel = new System.Windows.Forms.Label();
            userFunctionLabel = new System.Windows.Forms.Label();
            personEmailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c_UserBindingSource)).BeginInit();
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
            // personSocialNameLabel
            // 
            resources.ApplyResources(personSocialNameLabel, "personSocialNameLabel");
            personSocialNameLabel.Name = "personSocialNameLabel";
            // 
            // userSiretNumberLabel
            // 
            resources.ApplyResources(userSiretNumberLabel, "userSiretNumberLabel");
            userSiretNumberLabel.Name = "userSiretNumberLabel";
            // 
            // userFunctionLabel
            // 
            resources.ApplyResources(userFunctionLabel, "userFunctionLabel");
            userFunctionLabel.Name = "userFunctionLabel";
            // 
            // personEmailLabel
            // 
            resources.ApplyResources(personEmailLabel, "personEmailLabel");
            personEmailLabel.Name = "personEmailLabel";
            // 
            // c_UserBindingSource
            // 
            this.c_UserBindingSource.DataSource = typeof(ComptaxlData.C_User);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.userSiretNumberTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(personSocialNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.personSocialNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(personEmailLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.personEmailTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(personCityLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.personCityTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(personZipCodeLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.personZipCodeTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(personAddressLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.personAddressTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(userSiretNumberLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(personNameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(personFirstNameLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.personNameTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.personFirstNameTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(userFunctionLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.userFunctionTextBox, 1, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            // cPhoneTypeBindingSource
            // 
            this.cPhoneTypeBindingSource.DataSource = typeof(ComptaxlData.C_PhoneType);
            // 
            // phoneListBindingSource
            // 
            this.phoneListBindingSource.DataMember = "PhoneList";
            this.phoneListBindingSource.DataSource = this.c_UserBindingSource;
            // 
            // userSiretNumberTextBox
            // 
            resources.ApplyResources(this.userSiretNumberTextBox, "userSiretNumberTextBox");
            this.userSiretNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_UserBindingSource, "UserSiretNumber", true));
            this.userSiretNumberTextBox.Name = "userSiretNumberTextBox";
            // 
            // personSocialNameTextBox
            // 
            resources.ApplyResources(this.personSocialNameTextBox, "personSocialNameTextBox");
            this.personSocialNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_UserBindingSource, "PersonSocialName", true));
            this.personSocialNameTextBox.Name = "personSocialNameTextBox";
            // 
            // personEmailTextBox
            // 
            resources.ApplyResources(this.personEmailTextBox, "personEmailTextBox");
            this.personEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_UserBindingSource, "PersonEmail", true));
            this.personEmailTextBox.Name = "personEmailTextBox";
            // 
            // personCityTextBox
            // 
            resources.ApplyResources(this.personCityTextBox, "personCityTextBox");
            this.personCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_UserBindingSource, "PersonCity", true));
            this.personCityTextBox.Name = "personCityTextBox";
            // 
            // personZipCodeTextBox
            // 
            resources.ApplyResources(this.personZipCodeTextBox, "personZipCodeTextBox");
            this.personZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_UserBindingSource, "PersonZipCode", true));
            this.personZipCodeTextBox.Name = "personZipCodeTextBox";
            // 
            // personAddressTextBox
            // 
            this.personAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_UserBindingSource, "PersonAddress", true));
            resources.ApplyResources(this.personAddressTextBox, "personAddressTextBox");
            this.personAddressTextBox.Name = "personAddressTextBox";
            // 
            // personNameTextBox
            // 
            resources.ApplyResources(this.personNameTextBox, "personNameTextBox");
            this.personNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_UserBindingSource, "PersonName", true));
            this.personNameTextBox.Name = "personNameTextBox";
            // 
            // personFirstNameTextBox
            // 
            resources.ApplyResources(this.personFirstNameTextBox, "personFirstNameTextBox");
            this.personFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_UserBindingSource, "PersonFirstName", true));
            this.personFirstNameTextBox.Name = "personFirstNameTextBox";
            // 
            // userFunctionTextBox
            // 
            resources.ApplyResources(this.userFunctionTextBox, "userFunctionTextBox");
            this.userFunctionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_UserBindingSource, "UserFunction", true));
            this.userFunctionTextBox.Name = "userFunctionTextBox";
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
            this.phoneTypeDataGridViewTextBoxColumn.DisplayMember = "Designation";
            resources.ApplyResources(this.phoneTypeDataGridViewTextBoxColumn, "phoneTypeDataGridViewTextBoxColumn");
            this.phoneTypeDataGridViewTextBoxColumn.Name = "phoneTypeDataGridViewTextBoxColumn";
            this.phoneTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.phoneTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.phoneTypeDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // F_UserConfig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "F_UserConfig";
            ((System.ComponentModel.ISupportInitialize)(this.c_UserBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPhoneTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource c_UserBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox userFunctionTextBox;
        private System.Windows.Forms.TextBox userSiretNumberTextBox;
        private System.Windows.Forms.TextBox personSocialNameTextBox;
        private System.Windows.Forms.TextBox personEmailTextBox;
        private System.Windows.Forms.TextBox personCityTextBox;
        private System.Windows.Forms.TextBox personZipCodeTextBox;
        private System.Windows.Forms.TextBox personAddressTextBox;
        private System.Windows.Forms.TextBox personFirstNameTextBox;
        private System.Windows.Forms.TextBox personNameTextBox;
        private System.Windows.Forms.BindingSource cPhoneTypeBindingSource;
        private System.Windows.Forms.BindingSource phoneListBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn phoneTypeDataGridViewTextBoxColumn;
    }
}