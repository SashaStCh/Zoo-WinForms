using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDZoo_Information
    {
        #region Singleton
        private static CRUDZoo_Information instance;

        private CRUDZoo_Information()
        {

        }

        public static CRUDZoo_Information Instance
        {
            get
            {
                if (CRUDZoo_Information.instance == null)
                {
                    CRUDZoo_Information.instance = new CRUDZoo_Information();
                }
                return CRUDZoo_Information.instance;
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
            Zoo_Information zoo_Information = ZooRepository.Instance.Zoo_InformationSet.First(i => i.zoo_name == id);
            ZooRepository.Instance.Zoo_InformationSet.Remove(zoo_Information);
            ZooRepository.Instance.SaveChanges();
        }
    }
}
