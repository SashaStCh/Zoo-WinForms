using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDCashbox_Status
    {
        #region Singleton
        private static CRUDCashbox_Status instance;

        private CRUDCashbox_Status()
        {

        }

        public static CRUDCashbox_Status Instance
        {
            get
            {
                if (CRUDCashbox_Status.instance == null)
                {
                    CRUDCashbox_Status.instance = new CRUDCashbox_Status();
                }
                return CRUDCashbox_Status.instance;
            }
        }
        #endregion Singleton
    }
}
