using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Vendor
    {
        public int Id { get; set; }
        public string VendorNumber { get; set; }
        public string Description { get; set; }
        public string HDDescription { get; set; }
        public Nullable<bool> PaySubWhenPaid { get; set; }
    }
}
