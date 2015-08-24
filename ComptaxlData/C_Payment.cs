using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComptaxlData
{
    [Serializable]
    public class C_Payment:c_DataClassBase
    {
        private DateTime m_PaymentDate = DateTime.Now;

        public DateTime PaymentDate
        {
            get { return m_PaymentDate; }
            set { m_PaymentDate = value; }
        }
        private double m_PaymentAmmount = 0.0d;

        public double PaymentAmmount
        {
            get { return m_PaymentAmmount; }
            set { m_PaymentAmmount = value; }
        }
        private e_PaymentType m_PaymentType = e_PaymentType.CB;

        public e_PaymentType PaymentType
        {
            get { return m_PaymentType; }
            set { m_PaymentType = value; }
        }

        private string m_PaymentChequeNumber = string.Empty;

        public string PaymentChequeNumber
        {
            get { return m_PaymentChequeNumber; }
            set { m_PaymentChequeNumber = value; }
        }


        public C_Payment()
            : base()
        {
        }
    }
}
