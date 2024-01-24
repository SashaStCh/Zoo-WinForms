using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDAviary
    {
        #region Singleton
        private static CRUDAviary instance;

        private CRUDAviary()
        {

        }

        public static CRUDAviary Instance
        {
            get
            {
                if (CRUDAviary.instance == null)
                {
                    CRUDAviary.instance = new CRUDAviary();
                }
                return CRUDAviary.instance;
            }
        }
        #endregion Singleton
        public void Create()
        {

        }

        public void Update()
        {

        }

        public void Delete(Int32 id)
        {
            Aviary aviary = ZooRepository.Instance.AviarySet.First(i => i.aviary_code == id);
            ZooRepository.Instance.AviarySet.Remove(aviary);
            ZooRepository.Instance.SaveChanges();
        }
    }
}
