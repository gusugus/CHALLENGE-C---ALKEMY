//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class business_position
    {
        public business_position()
        {
            this.person_business_position = new HashSet<person_business_position>();
        }
    
        public int id_business_position { get; set; }
        public Nullable<int> business_id { get; set; }
        public Nullable<int> position_id { get; set; }
    
        public virtual business business { get; set; }
        public virtual position position { get; set; }
        public virtual ICollection<person_business_position> person_business_position { get; set; }
    }
}
