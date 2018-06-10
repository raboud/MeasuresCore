using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MeasureCustomerStore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<System.DateTime> Enterred { get; set; }
        public string Branch { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> MeasureId { get; set; }
    }
}
