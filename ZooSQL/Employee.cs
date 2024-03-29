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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Feeding_Time = new HashSet<Feeding_Time>();
            this.History_Work_Shift = new HashSet<History_Work_Shift>();
            this.Status_Changes = new HashSet<Status_Changes>();
        }
    
        public int emp_code { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string patronymic { get; set; }
        public string emp_gender { get; set; }
        public decimal salary { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public System.TimeSpan start_schedule { get; set; }
        public System.TimeSpan finish_schedule { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feeding_Time> Feeding_Time { get; set; }
        public virtual Job Job { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History_Work_Shift> History_Work_Shift { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Status_Changes> Status_Changes { get; set; }
    }
}
