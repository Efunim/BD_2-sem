//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD_6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int recordID { get; set; }
        public int productID { get; set; }
        public int providerID { get; set; }
        public Nullable<System.DateTime> purchase_date { get; set; }
        public int count { get; set; }
        public int employeeID { get; set; }
    
        public virtual Employees employees { get; set; }
        public virtual Products products { get; set; }
        public virtual Provider provider { get; set; }
    }
}
