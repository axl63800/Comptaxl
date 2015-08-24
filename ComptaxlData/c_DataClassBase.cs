using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComptaxlData
{
    [Serializable]
    public class c_DataClassBase
    {
        protected Guid m_Id = Guid.Empty;

        public Guid Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        protected c_DataClassBase()
        {
            m_Id = Guid.NewGuid();
        }
    }
}
