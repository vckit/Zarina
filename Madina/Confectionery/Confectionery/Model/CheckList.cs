//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Confectionery.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckList
    {
        public int id { get; set; }
        public int idProduct { get; set; }
        public int idClient { get; set; }
        public int count { get; set; }
        public double totalPrice { get; set; }
        public System.DateTime dateCheck { get; set; }
        public int idPayment { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Product Product { get; set; }
    }
}
