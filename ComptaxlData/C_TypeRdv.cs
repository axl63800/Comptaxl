using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComptaxlData
{
    [Serializable]
    public class C_TypeRdv:c_DataClassBase
    {
        private string m_TypeRdvDesign = string.Empty;

        public string TypeRdvDesign
        {
            get { return m_TypeRdvDesign; }
            set { m_TypeRdvDesign = value; }
        }

        public C_TypeRdv()
            : base()
        {
        }
    }
}
