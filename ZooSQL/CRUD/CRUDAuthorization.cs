using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDAuthorization
    {
        #region Singleton
        private static CRUDAuthorization instance;

        private CRUDAuthorization()
        {

        }

        public static CRUDAuthorization Instance
        {
            get
            {
                if (CRUDAuthorization.instance == null)
                {
                    CRUDAuthorization.instance = new CRUDAuthorization();
                }
                return CRUDAuthorization.instance;
            }
        }
        #endregion Singleton

        public void Create()
        {

        }

        public void Read()
        {
            foreach (Authorization authorization in ZooRepository.Instance.AuthorizationSet)
            {
                Console.WriteLine("{0} {1}", authorization.login, authorization.password);
            }
        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}
