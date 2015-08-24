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
    public partial class Comptaxl : Form
    {
        private C_ComptaxlData m_Data;
        private F_Clients m_fClient;
        private F_Rdv m_fRdv;
        private F_TypeRdv m_fTypeRdv;
        private F_UserConfig m_fUserConfig;

        public C_ComptaxlData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }

        public Comptaxl()
        {
            InitializeComponent();
            m_Data = new C_ComptaxlData();
            
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Comptaxl_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_Data.Serialize();
        }

        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_fClient == null || m_fClient.IsDisposed)
            {
                m_fClient = new F_Clients(m_Data);
                m_fClient.MdiParent = this;
                m_fClient.Show();
            }
            m_fClient.BringToFront();
        }

        private void rendezVousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_fRdv == null || m_fRdv.IsDisposed)
            {
                m_fRdv = new F_Rdv(m_Data);
                m_fRdv.MdiParent = this;
                m_fRdv.Show();
            }
            m_fRdv.BringToFront();
        }

        private void editionDesTypesDeRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_fTypeRdv == null || m_fTypeRdv.IsDisposed)
            {
                m_fTypeRdv = new F_TypeRdv(m_Data);
                m_fTypeRdv.MdiParent = this;
                m_fTypeRdv.Show();
            }
            m_fTypeRdv.BringToFront();
        }

        private void configurationUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_fUserConfig == null || m_fUserConfig.IsDisposed)
            {
                m_fUserConfig = new F_UserConfig(m_Data);
                m_fUserConfig.MdiParent = this;
                m_fUserConfig.Show();
            }
            m_fUserConfig.BringToFront();
        }
    }
}
