using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Client
    {
        public Client()
        {
            this.Clients = new List<Client>();
            this.PhoneNumbers = new List<PhoneNumberClient>();
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
        public string Name { get; set; }

        public Nullable<int> ParentId { get; set; }
        public Client Parent { get; set; }
        public List<Client> Clients { get; set; }
        [NotMapped]
        public string DisplayName => (this.Parent != null ? this.Parent.DisplayName + " - " : "") + this.Name;

        public List<PhoneNumberClient> PhoneNumbers { get; set; }
    }
}
