using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class BillDetail
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public bool NoRetainage { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> WorkOrderId { get; set; }
        public string Name { get; set; }
		[Money]
        public Nullable<decimal> PayAmount { get; set; }
        public string Comments { get; set; }
        public int ClassificationId { get; set; }
        public Nullable<int> BackChargeOwnerId { get; set; }
        public Nullable<int> ChargeBackId { get; set; }
        public string QBUid { get; set; }
    
        public Bill Bill { get; set; }
        public ChargeBack ChargeBack { get; set; }
        public SubContractor SubContractor { get; set; }
        public WorkOrder WorkOrder { get; set; }
    }
}
