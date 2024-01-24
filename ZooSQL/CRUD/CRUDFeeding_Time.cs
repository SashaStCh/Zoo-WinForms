using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDFeeding_Time
    {
        #region Singleton
        private static CRUDFeeding_Time instance;

        private CRUDFeeding_Time()
        {

        }

        public static CRUDFeeding_Time Instance
        {
            get
            {
                if (CRUDFeeding_Time.instance == null)
                {
                    CRUDFeeding_Time.instance = new CRUDFeeding_Time();
                }
                return CRUDFeeding_Time.instance;
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
            Feeding_Time feeding_Time = ZooRepository.Instance.Feeding_TimeSet.First(i => i.f_time == id);
            ZooRepository.Instance.Feeding_TimeSet.Remove(feeding_Time);
            ZooRepository.Instance.SaveChanges();
        }
    }
}
