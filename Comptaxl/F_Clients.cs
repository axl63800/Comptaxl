using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComptaxlData;

namespace Comptaxl
{
    public partial class F_Clients : Form
    {
        private C_ComptaxlData m_data;

        public C_ComptaxlData Data
        {
            get { return m_data; }
            set { m_data = value; }
        }
        public F_Clients(C_ComptaxlData data)
        {
            InitializeComponent();
            m_data = data;
            ctrlClientDetail1.PhoneTypeBindingSource = cPhoneTypeBindingSource;
            cPhoneTypeBindingSource.ResetBindings(false);
            cClientBindingSource.DataSource = m_data.ClientList;
            ctrlClientDetail1.ClientBindingSource = cClientBindingSource;
            cClientBindingSource.ResetBindings(false);
            cPhoneTypeBindingSource.DataSource = m_data.PhoneTypeList;
            
        }

        private void F_Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            m_data.Serialize();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            ctrlClientDetail1.ClientBindingSource = cClientBindingSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            C_Client NewClient = new C_Client();
            m_data.ClientList.Add(NewClient);
            cClientBindingSource.ResetBindings(false);
            listBox1.SelectedItem = NewClient;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            m_data.ClientList.Remove((C_Client)listBox1.SelectedItem);
            cClientBindingSource.ResetBindings(false);
        }

        private void cClientBindingSource_PositionChanged(object sender, EventArgs e)
        {

        }
    }
}
