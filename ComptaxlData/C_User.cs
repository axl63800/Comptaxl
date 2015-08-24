using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComptaxlData
{
    [Serializable]
    public class C_User:C_Person
    {
      
        private string m_UserSiretNumber = string.Empty;

        public string UserSiretNumber
        {
            get { return m_UserSiretNumber; }
            set { m_UserSiretNumber = value; }
        }

        private string m_UserFunction = string.Empty;

        public string UserFunction
        {
            get { return m_UserFunction; }
            set { m_UserFunction = value; }
        }


        public C_User()
            : base()
        {
        }
    }
}
