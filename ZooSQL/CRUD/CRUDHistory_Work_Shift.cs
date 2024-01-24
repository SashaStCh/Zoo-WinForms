using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDHistory_Work_Shift
    {
        #region Singleton
        private static CRUDHistory_Work_Shift instance;

        private CRUDHistory_Work_Shift()
        {

        }

        public static CRUDHistory_Work_Shift Instance
        {
            get
            {
                if (CRUDHistory_Work_Shift.instance == null)
                {
                    CRUDHistory_Work_Shift.instance = new CRUDHistory_Work_Shift();
                }
                return CRUDHistory_Work_Shift.instance;
            }
        }
        #endregion Singleton
        public void Create()
        {

        }

        public void Update()
        {

        }

        public void Delete(DateTime id)
        {
            History_Work_Shift history = ZooRepository.Instance.History_Work_ShiftSet.First(i => i.time_a_l == id);
            ZooRepository.Instance.History_Work_ShiftSet.Remove(history);
            ZooRepository.Instance.SaveChanges();
        }
    }
}
