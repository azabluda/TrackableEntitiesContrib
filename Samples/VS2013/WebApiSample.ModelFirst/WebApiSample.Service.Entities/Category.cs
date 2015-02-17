//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiSample.Service.Entities
{
    using System;
    using System.Collections.Generic;
    using TrackableEntities;
    
    public partial class Category : ITrackable, IMergeable
    {
        public Category()
        {
            this.Products = new List<Product>();
        }
    
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    
        public ICollection<Product> Products { get; set; }
    
        public TrackingState TrackingState { get; set; }
        public ICollection<string> ModifiedProperties { get; set; }
        public Guid EntityIdentifier { get; set; }
    }
}
