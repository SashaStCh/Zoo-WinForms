using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDWork_Shift
    {
        #region Singleton
        private static CRUDWork_Shift instance;

        private CRUDWork_Shift()
        {

        }

        public static CRUDWork_Shift Instance
        {
            get
            {
                if (CRUDWork_Shift.instance == null)
                {
                    CRUDWork_Shift.instance = new CRUDWork_Shift();
                }
                return CRUDWork_Shift.instance;
            }
        }
        #endregion Singleton
    }
}
