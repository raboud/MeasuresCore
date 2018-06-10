using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Customer
    {
        public Customer()
        {
            //this.MeasureCompCustDatas = new HashSet<MeasureCompCustData>();
            //this.Orders = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkNumber { get; set; }
        public string Directions { get; set; }
        public string Extension { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDateTime { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string CompanyName { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string QBCustomerId { get; set; }
        public string Name { get; set; }
    
//        public List<MeasureCompCustData> MeasureCompCustDatas { get; set; }
//        public List<Order> Orders { get; set; }
    }
}
