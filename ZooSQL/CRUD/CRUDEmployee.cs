using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDEmployee
    {
        #region Singleton
        private static CRUDEmployee instance;

        private CRUDEmployee()
        {

        }

        public static CRUDEmployee Instance
        {
            get
            {
                if (CRUDEmployee.instance == null)
                {
                    CRUDEmployee.instance = new CRUDEmployee();
                }
                return CRUDEmployee.instance;
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
            Employee employee= ZooRepository.Instance.EmployeeSet.First(i => i.emp_code == id);
            ZooRepository.Instance.EmployeeSet.Remove(employee);
            ZooRepository.Instance.SaveChanges();
        }
    }
}
