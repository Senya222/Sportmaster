//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportMagazin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tovar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tovar()
        {
            this.Sklad_Tovar = new HashSet<Sklad_Tovar>();
            this.Zakaz_Tovar = new HashSet<Zakaz_Tovar>();
        }
    
        public int ID { get; set; }
        public string Nazvanie { get; set; }
        public string Opisanie { get; set; }
        public int IDProizvoditel { get; set; }
        public decimal Cena { get; set; }
        public string Foto { get; set; }
    
        public virtual Proizvoditel Proizvoditel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sklad_Tovar> Sklad_Tovar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zakaz_Tovar> Zakaz_Tovar { get; set; }
    }
}
