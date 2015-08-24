using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComptaxlData
{
    [Serializable]
    public class C_Rdv:c_DataClassBase
    {
        private Guid m_IdPerson = Guid.Empty;

        public Guid IdPerson
        {
            get { return m_IdPerson; }
            set { m_IdPerson = value; }
        }
        private DateTime m_RdvDateTime = DateTime.Now;

        public DateTime RdvDateTime
        {
            get { return m_RdvDateTime; }
            set { m_RdvDateTime = value; }
        }
        private Guid m_IdTypeRdv = Guid.Empty;

        public Guid IdTypeRdv
        {
            get { return m_IdTypeRdv; }
            set { m_IdTypeRdv = value; }
        }
        private double m_RdvAmount = 0.0d;

        public double RdvAmount
        {
            get { return m_RdvAmount; }
            set { m_RdvAmount = value; }
        }

        private List<C_Payment> m_RdvPayments;

        public List<C_Payment> RdvPayments
        {
            get { if (m_RdvPayments == null) m_RdvPayments = new List<C_Payment>(); return m_RdvPayments; }
            set { m_RdvPayments = value; }
        }

        public C_Rdv()
            : base()
        {
        }
    }
}
