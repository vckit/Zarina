//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JewerlyStore.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Check
    {
        public int ID { get; set; }
        public int IDClient { get; set; }
        public int IDJewelry { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<double> Commission { get; set; }
        public double TotalPrice { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Jewelry Jewelry { get; set; }
    }
}
