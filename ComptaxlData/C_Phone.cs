using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComptaxlData
{
    [Serializable]
    public class C_Phone : c_DataClassBase
    {
       
        private string m_PhoneNumber = string.Empty;

        public string PhoneNumber
        {
            get { return m_PhoneNumber; }
            set { m_PhoneNumber = value; }
        }
        private Guid m_PhoneType;

        public Guid PhoneType
        {
            get { if (m_PhoneType == null) m_PhoneType = Guid.Empty; return m_PhoneType; }
            set { m_PhoneType = value; }
        }
        public C_Phone()
            : base()
        {
        }
    }
}
