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
    public partial class F_Rdv : Form
    {

        private C_ComptaxlData m_data;

        public C_ComptaxlData Data
        {
            get { return m_data; }
            set { m_data = value; }
        }
        private List<C_Rdv> m_FilteredRdvList;
        public F_Rdv(C_ComptaxlData data)
        {
            InitializeComponent();
            m_data = data;
            cTypeRdvBindingSource.DataSource = m_data.TypeRdvList;
            cClientBindingSource.DataSource = m_data.ClientList;
            FilterRdvList();
            c_RdvBindingSource.DataSource = m_FilteredRdvList;
            

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterRdvList();
            
        }
        private void FilterRdvList()
        {
            Guid IdPerson = Guid.Empty;

            if (comboBox1.SelectedValue != null) IdPerson = (Guid)comboBox1.SelectedValue;
            m_FilteredRdvList = (from rdv in m_data.RdvList where rdv.IdPerson == IdPerson select rdv).ToList<C_Rdv>();
            c_RdvBindingSource.DataSource = m_FilteredRdvList;
            SetTextFact();
        }

        private void SetTextFact()
        {
            double totalFact = (from rdv in m_FilteredRdvList select rdv.RdvAmount).Sum();
            double TotalPaym = (from rdv in m_FilteredRdvList select (from pay in rdv.RdvPayments select pay.PaymentAmmount).Sum()).Sum();
            if (totalFact - TotalPaym > 0) lblPaymentsPending.Text = "Reste a facturer : " + (totalFact - TotalPaym).ToString("0.00€");
            else lblPaymentsPending.Text = string.Empty;
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void c_RdvBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            m_data.RdvList.AddRange((from rdv in m_FilteredRdvList where !m_data.RdvList.Contains(rdv) select rdv).ToList<C_Rdv>());
            SetTextFact();
        }

        private void c_RdvBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            C_Rdv New = new C_Rdv();
            if (comboBox1.SelectedValue != null) New.IdPerson = (Guid)comboBox1.SelectedValue;
            e.NewObject = New;
        }

        private void F_Rdv_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            m_data.Serialize();
        }

        private void btnReloadListPatient_Click(object sender, EventArgs e)
        {
            cClientBindingSource.DataSource = m_data.ClientList;
            cClientBindingSource.ResetBindings(false);
        }

        private void c_RdvBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
