using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDTicket
    {
        #region Singleton
        private static CRUDTicket instance;

        private CRUDTicket()
        {

        }

        public static CRUDTicket Instance
        {
            get
            {
                if (CRUDTicket.instance == null)
                {
                    CRUDTicket.instance = new CRUDTicket();
                }
                return CRUDTicket.instance;
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
            Ticket ticket = ZooRepository.Instance.TicketSet.First(i => i.ticket_code == id);
            ZooRepository.Instance.TicketSet.Remove(ticket);
            ZooRepository.Instance.SaveChanges();
        }
    }
}
