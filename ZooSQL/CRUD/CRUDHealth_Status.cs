using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDHealth_Status
    {
        #region Singleton
        private static CRUDHealth_Status instance;

        private CRUDHealth_Status()
        {

        }

        public static CRUDHealth_Status Instance
        {
            get
            {
                if (CRUDHealth_Status.instance == null)
                {
                    CRUDHealth_Status.instance = new CRUDHealth_Status();
                }
                return CRUDHealth_Status.instance;
            }
        }
        #endregion Singleton
    }
}
