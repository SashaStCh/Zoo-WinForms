using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDJob
    {
        #region Singleton
        private static CRUDJob instance;

        private CRUDJob()
        {

        }

        public static CRUDJob Instance
        {
            get
            {
                if (CRUDJob.instance == null)
                {
                    CRUDJob.instance = new CRUDJob();
                }
                return CRUDJob.instance;
            }
        }
        #endregion Singleton
    }
}
