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
    
    public partial class Animal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Animal()
        {
            this.Feeding_Time = new HashSet<Feeding_Time>();
            this.Animal_Analysis = new HashSet<Animal_Analysis>();
        }
    
        public int animal_code { get; set; }
        public string animal_name { get; set; }
        public string animal_gender { get; set; }
        public string color { get; set; }
        public System.DateTime date_of_birth { get; set; }
    
        public virtual Speties Speties { get; set; }
        public virtual Aviary Aviary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feeding_Time> Feeding_Time { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Animal_Analysis> Animal_Analysis { get; set; }
    }
}
