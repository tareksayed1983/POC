//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Poc.Model
{
     
    using System;
    using System.Collections.Generic;
    
    [Serializable]
    public partial class Product
    {
        public System.Guid ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
