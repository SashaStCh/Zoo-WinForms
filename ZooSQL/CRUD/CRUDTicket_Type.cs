using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDTicket_Type
    {
        #region Singleton
        private static CRUDTicket_Type instance;

        private CRUDTicket_Type()
        {

        }

        public static CRUDTicket_Type Instance
        {
            get
            {
                if (CRUDTicket_Type.instance == null)
                {
                    CRUDTicket_Type.instance = new CRUDTicket_Type();
                }
                return CRUDTicket_Type.instance;
            }
        }
        #endregion Singleton
    }
}
