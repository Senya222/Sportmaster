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
    
    public partial class Sklad_Tovar
    {
        public int ID { get; set; }
        public int IDSklad { get; set; }
        public int IDTovar { get; set; }
        public int Kolichestvo { get; set; }
    
        public virtual Sklad Sklad { get; set; }
        public virtual Tovar Tovar { get; set; }
    }
}
