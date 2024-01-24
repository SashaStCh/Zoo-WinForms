using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooSQL
{
    class CRUDAnimal
    {
        #region Singleton
        private static CRUDAnimal instance;

        private CRUDAnimal()
        {

        }

        public static CRUDAnimal Instance
        {
            get
            {
                if (CRUDAnimal.instance == null)
                {
                    CRUDAnimal.instance = new CRUDAnimal();
                }
                return CRUDAnimal.instance;
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
            Animal animal = ZooRepository.Instance.AnimalSet.First(i => i.animal_code == id);
            ZooRepository.Instance.AnimalSet.Remove(animal);
            ZooRepository.Instance.SaveChanges();
        }
    }
}
