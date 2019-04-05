using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Tech
    {
		public int Id { get; set; }
		public Address Address { get; set; }
        public string EmailAddress { get; set; }
        public string UserId { get; set; }
        public bool Active { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
    
        public AspNetUser User { get; set; }
        public AspNetUser LastModifiedBy { get; set; }
        public List<TechCapacity> Capacities { get; set; }
        public List<Store> Stores { get; set; }
    }
}
