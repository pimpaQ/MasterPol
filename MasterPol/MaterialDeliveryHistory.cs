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
    
    public partial class MaterialDeliveryHistory
    {
        public int ID { get; set; }
        public Nullable<int> IDDeliver { get; set; }
        public Nullable<int> IDMaterial { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<int> Count { get; set; }
    
        public virtual Delivers Delivers { get; set; }
        public virtual Materials Materials { get; set; }
    }
}
