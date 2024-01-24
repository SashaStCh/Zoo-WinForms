using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDCashbox
    {
        #region Singleton
        private static CRUDCashbox instance;

        private CRUDCashbox()
        {

        }

        public static CRUDCashbox Instance
        {
            get
            {
                if (CRUDCashbox.instance == null)
                {
                    CRUDCashbox.instance = new CRUDCashbox();
                }
                return CRUDCashbox.instance;
            }
        }
        #endregion Singleton

        public void Create()
        {
            ZooRepository.Instance.CashboxSet.Add(new Cashbox());
            ZooRepository.Instance.SaveChanges();
        }
        public void Update()
        {

        }
        public void Delete(Int32 Id)
        {
            Cashbox cashbox = ZooRepository.Instance.CashboxSet.First(i => i.cashbox_code == Id);
            ZooRepository.Instance.CashboxSet.Remove(cashbox);
            ZooRepository.Instance.SaveChanges();
        }

    }
}
