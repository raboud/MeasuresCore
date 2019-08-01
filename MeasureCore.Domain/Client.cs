using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Client : WithParent<Client>
    {
        public Client()
        {
            this.PhoneNumbers = new List<PhoneNumber>();
        }
    
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Address BillingAddress { get; set; }
        public string Directions { get; set; }

        public WhoDidIt Modified { get; set; }
        public string EmailAddress { get; set; }
        public string QBCustomerId { get; set; }
        public override string Name { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}
