using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComptaxlData
{
    [Serializable]
    public class C_Client:C_Person
    {
        private DateTime m_ClientBirthdate = new DateTime(1800, 01, 01);

        public DateTime ClientBirthdate
        {
            get { if (m_ClientBirthdate == null || m_ClientBirthdate < new DateTime(1800, 01, 01)) m_ClientBirthdate = new DateTime(1800, 01, 01); return m_ClientBirthdate; }
            set { m_ClientBirthdate = value; }
        }

        private string m_ClientCommentaire = string.Empty;

        public string ClientCommentaire
        {
            get { if (m_ClientCommentaire == null) m_ClientCommentaire = string.Empty; return m_ClientCommentaire; }
            set { m_ClientCommentaire = value; }
        }

        public C_Client():base()
        {
            
        }
    }
}
