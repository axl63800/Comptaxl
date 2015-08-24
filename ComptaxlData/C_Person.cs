using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComptaxlData
{
    [Serializable]
    public class C_Person:c_DataClassBase
    {
        protected string m_PersonName = string.Empty;

        public string PersonName
        {
            get { return m_PersonName; }
            set { m_PersonName = value; }
        }
        protected string m_PersonFirstName = string.Empty;

        public string PersonFirstName
        {
            get { return m_PersonFirstName; }
            set { m_PersonFirstName = value; }
        }
        protected string m_PersonAddress = string.Empty;

        public string PersonAddress
        {
            get { return m_PersonAddress; }
            set { m_PersonAddress = value; }
        }
        protected string m_PersonZipCode = string.Empty;

        public string PersonZipCode
        {
            get { return m_PersonZipCode; }
            set { m_PersonZipCode = value; }
        }
        protected string m_PersonCity = string.Empty;

        public string PersonCity
        {
            get { return m_PersonCity; }
            set { m_PersonCity = value; }
        }
        protected string m_PersonSocialName = string.Empty;

        public string PersonSocialName
        {
            get { return m_PersonSocialName; }
            set { m_PersonSocialName = value; }
        }
        
        protected string m_PersonEmail = string.Empty;

        public string PersonEmail
        {
            get { return m_PersonEmail; }
            set { m_PersonEmail = value; }
        }

        public string PersonFullName
        {
            get { return m_PersonName + " " + m_PersonFirstName; }
        }

        public override string ToString()
        {
            return PersonFullName;
        }
        protected List<C_Phone> m_PhoneList;

        public List<C_Phone> PhoneList
        {
            get { if (m_PhoneList == null) m_PhoneList = new List<C_Phone>(); return m_PhoneList; }
            set { m_PhoneList = value; }
        }

        public C_Person():base()
        {
            
        }
        
    }
}
