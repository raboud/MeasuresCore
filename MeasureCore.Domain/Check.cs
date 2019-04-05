using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Check
    {
        public int Id { get; set; }
        public string CheckNumber { get; set; }

        [Date]
        public Nullable<System.DateTime> CheckDate { get; set; }
		[Money]
		public Nullable<decimal> Amount { get; set; }
        public int VendorId { get; set; }
        public string QBTxnId { get; set; }
    
        public List<CheckCBDetail> CheckCBDetails { get; set; }
        public List<CheckDetail> CheckDetails { get; set; }
    }
}
