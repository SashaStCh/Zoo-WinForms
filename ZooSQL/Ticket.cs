//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZooSQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int ticket_code { get; set; }
        public System.DateTime date_of_purchase { get; set; }
    
        public virtual Cashbox Cashbox { get; set; }
        public virtual Ticket_Type Ticket_Type { get; set; }
    }
}
