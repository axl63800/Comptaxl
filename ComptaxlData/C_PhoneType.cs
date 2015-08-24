using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComptaxlData
{
    [Serializable]
    public class C_PhoneType:c_DataClassBase
    {
        private string m_Designation = string.Empty;

        public string Designation
        {
            get { return m_Designation; }
            set { m_Designation = value; }
        }

        public C_PhoneType()
            : base()
        {
        }
        public C_PhoneType(string designation)
            : base()
        {
            m_Designation = designation;
        }
        public override string ToString()
        {
            return m_Designation;
        }
    }
}
