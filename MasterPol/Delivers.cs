//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPol
{
    using System;
    using System.Collections.Generic;
    
    public partial class Delivers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delivers()
        {
            this.MaterialDeliveryHistory = new HashSet<MaterialDeliveryHistory>();
        }
    
        public int DeliversID { get; set; }
        public Nullable<int> DeliversType { get; set; }
        public string DeliversName { get; set; }
        public string DeliversINN { get; set; }
    
        public virtual DeliversType DeliversType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialDeliveryHistory> MaterialDeliveryHistory { get; set; }
    }
}
