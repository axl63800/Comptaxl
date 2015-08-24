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
    public partial class F_TypeRdv : Form
    {
        private C_ComptaxlData m_data;

        public C_ComptaxlData Data
        {
            get { return m_data; }
            set { m_data = value; }
        }

        public F_TypeRdv(C_ComptaxlData data)
        {
            InitializeComponent();
            m_data = data;
            c_TypeRdvBindingSource.DataSource = m_data.TypeRdvList;
        }

        private void F_TypeRdv_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            m_data.Serialize();
        }
    }
}
