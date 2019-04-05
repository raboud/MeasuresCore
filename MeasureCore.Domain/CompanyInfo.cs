using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class CompanyInfo
    {
        public CompanyInfo()
        {
            this.PhoneNumbers = new List<PhoneNumber>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public byte[] WaiverSignature { get; set; }
        public byte[] Logo { get; set; }
        public string QRCodePrefix { get; set; }
        public string TollFree { get; set; }

        List<PhoneNumber> PhoneNumbers { get; set; }
    }

    public class PhoneNumberCompany : PhoneNumber
    {
        public int CompanyInfoId { get; set; }
        public bool Active { get; set; }

    }

}
