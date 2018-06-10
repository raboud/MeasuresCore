using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class ChargeBack
    {
        public int Id { get; set; }

		[Money]
        public decimal Amount { get; set; }
		[Money]

		public decimal AmountToSub { get; set; }
		public int SubcontractorId { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Reason { get; set; }
        public System.DateTime IssueDate { get; set; }
        public string OriginalPO { get; set; }
        public Nullable<bool> CostAdjustment { get; set; }
        public Nullable<int> OrderId { get; set; }
        public int ApprovalNumber { get; set; }
        public bool Approved { get; set; }
    
        public List<BillDetail> BillDetails { get; set; }
        public Order Order { get; set; }
        public List<CheckCBDetail> CheckCBDetails { get; set; }
    }
}
