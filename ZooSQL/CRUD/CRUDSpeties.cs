using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDSpeties
    {
        #region Singleton
        private static CRUDSpeties instance;

        private CRUDSpeties()
        {

        }

        public static CRUDSpeties Instance
        {
            get
            {
                if (CRUDSpeties.instance == null)
                {
                    CRUDSpeties.instance = new CRUDSpeties();
                }
                return CRUDSpeties.instance;
            }
        }
        #endregion Singleton
        public void Create()
        {

        }

        public void Update()
        {

        }

        public void Delete(String id)
        {
            Speties species = ZooRepository.Instance.SpetiesSet.First(i => i.species_name == id);
            ZooRepository.Instance.SpetiesSet.Remove(species);
            ZooRepository.Instance.SaveChanges();
        }
    }
}
