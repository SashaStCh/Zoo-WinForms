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
    
    public partial class History_Work_Shift
    {
        public System.DateTime time_a_l { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Work_Shift Work_Shift { get; set; }
    }
}