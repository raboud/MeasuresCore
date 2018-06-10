using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class CompanyInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string VendorNumber { get; set; }
        public byte[] WaiverSignature { get; set; }
        public byte[] Logo { get; set; }
        public string QRCodePrefix { get; set; }
        public string TollFree { get; set; }
    }
}
