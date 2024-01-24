using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDFood_Ration
    {
        #region Singleton
        private static CRUDFood_Ration instance;

        private CRUDFood_Ration()
        {

        }

        public static CRUDFood_Ration Instance
        {
            get
            {
                if (CRUDFood_Ration.instance == null)
                {
                    CRUDFood_Ration.instance = new CRUDFood_Ration();
                }
                return CRUDFood_Ration.instance;
            }
        }
        #endregion Singleton
    }
}
