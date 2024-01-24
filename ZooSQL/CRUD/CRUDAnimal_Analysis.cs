using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDAnimal_Analysis
    {
        #region Singleton
        private static CRUDAnimal_Analysis instance;

        private CRUDAnimal_Analysis()
        {

        }

        public static CRUDAnimal_Analysis Instance
        {
            get
            {
                if (CRUDAnimal_Analysis.instance == null)
                {
                    CRUDAnimal_Analysis.instance = new CRUDAnimal_Analysis();
                }
                return CRUDAnimal_Analysis.instance;
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
            Animal_Analysis analysis = ZooRepository.Instance.Animal_AnalysisSet.First(i => i.analysis_code == id);
            ZooRepository.Instance.Animal_AnalysisSet.Remove(analysis);
            ZooRepository.Instance.SaveChanges();
        }
    }
}
