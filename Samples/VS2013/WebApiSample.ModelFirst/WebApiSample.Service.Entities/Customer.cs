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
    
    public partial class Customer : ITrackable, IMergeable
    {
        public Customer()
        {
            this.Orders = new List<Order>();
            this.Location = new Location();
        }
    
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
    
        public Location Location { get; set; }
    
        public CustomerSetting CustomerSetting { get; set; }
        public ICollection<Order> Orders { get; set; }
    
        public TrackingState TrackingState { get; set; }
        public ICollection<string> ModifiedProperties { get; set; }
        public Guid EntityIdentifier { get; set; }
    }
}
