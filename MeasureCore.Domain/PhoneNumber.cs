using System;
using System.Collections.Generic;
using System.Text;

namespace RandREng.MeasuresCore.Domain
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int PhoneNumberTypeId { get; set; }
        public PhoneNumberType PhoneNumberType { get; set; }
    }

    public class PhoneNumberContact
    {
        public int PhoneNumberId { get; set; }
        public int ContactId { get; set; }
        public bool Active { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Contact Contact { get; set; }
    }

    public class PhoneNumberClient
    {
        public int PhoneNumberId { get; set; }
        public int ClientId { get; set; }
        public bool Active { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Client Client { get; set; }
    }
}
