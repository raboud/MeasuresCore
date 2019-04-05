using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Bill
    {
        public int Id { get; set; }
		public int SubContractorId { get; set; }
		[Money]
        public decimal TotalPaid { get; set; }
		[Money]
        public decimal Retainage { get; set; }
		[Money]
        public decimal Insurance { get; set; }
        [Date]
        public System.DateTime PayDay { get; set; }
        public bool Paid { get; set; }
        public int OwnerId { get; set; }
        public string QBTxnId { get; set; }
    
        public SubContractor SubContractor { get; set; }
        public List<BillDetail> BillDetails { get; set; }
    }
}
