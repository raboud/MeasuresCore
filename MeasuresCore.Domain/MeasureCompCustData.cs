using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MeasureCompCustData
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string HomePhone { get; set; }
        public string BusinessPhone { get; set; }
        public string CellPhone { get; set; }
        public string Pager { get; set; }
        public string CrossStreetDir1 { get; set; }
        public string CrossStreet1 { get; set; }
        public string CrossStreetDir2 { get; set; }
        public string CrossStreet2 { get; set; }
        public string EmailAddress { get; set; }
    
        public Customer Customer { get; set; }
    }
}
