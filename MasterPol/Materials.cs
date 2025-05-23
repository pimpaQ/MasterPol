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
    
    public partial class Materials
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materials()
        {
            this.MaterialCountChangeHistory = new HashSet<MaterialCountChangeHistory>();
            this.MaterialDeliveryHistory = new HashSet<MaterialDeliveryHistory>();
            this.ProductMaterial = new HashSet<ProductMaterial>();
        }
    
        public int MaterialID { get; set; }
        public int MaterialType { get; set; }
        public string MaterialName { get; set; }
        public int DeliveryID { get; set; }
        public int CountInPackage { get; set; }
        public string UoM { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Cost { get; set; }
        public int CointInStorage { get; set; }
        public int MinCount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialCountChangeHistory> MaterialCountChangeHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialDeliveryHistory> MaterialDeliveryHistory { get; set; }
        public virtual MaterialType MaterialType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMaterial> ProductMaterial { get; set; }
    }
}
