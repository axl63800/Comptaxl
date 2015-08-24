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
    public partial class F_UserConfig : Form
    {
        private C_ComptaxlData m_data;

        public C_ComptaxlData Data
        {
            get { return m_data; }
            set { m_data = value; }
        }

        public F_UserConfig(C_ComptaxlData data)
        {
            InitializeComponent();
            m_data = data;
            cPhoneTypeBindingSource.DataSource = m_data.PhoneTypeList;
            c_UserBindingSource.DataSource = m_data.UserList;
            if (c_UserBindingSource.Count == 0) c_UserBindingSource.AddNew();
            else c_UserBindingSource.MoveFirst();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
