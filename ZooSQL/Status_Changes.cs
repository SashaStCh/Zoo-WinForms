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
    
    public partial class Status_Changes
    {
        public System.DateTime status_date { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Cashbox_Status Cashbox_Status { get; set; }
        public virtual Cashbox Cashbox { get; set; }
    }
}
