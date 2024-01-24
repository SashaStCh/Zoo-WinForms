using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDStatus_Changes
    {
        #region Singleton
        private static CRUDStatus_Changes instance;

        private CRUDStatus_Changes()
        {

        }

        public static CRUDStatus_Changes Instance
        {
            get
            {
                if (CRUDStatus_Changes.instance == null)
                {
                    CRUDStatus_Changes.instance = new CRUDStatus_Changes();
                }
                return CRUDStatus_Changes.instance;
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
            Status_Changes status_Changes = ZooRepository.Instance.Status_ChangesSet.First(i => i.status_date == id);
            ZooRepository.Instance.Status_ChangesSet.Remove(status_Changes);
            ZooRepository.Instance.SaveChanges();
        }
    }
}
