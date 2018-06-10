using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class StoreWithBranch
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string NickName { get; set; }
        public string BranchName { get; set; }
        public string StoreType { get; set; }
        public bool Active { get; set; }
        public string Number { get; set; }
        public Nullable<short> DistrictNumber { get; set; }
    }
}
