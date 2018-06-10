using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class WorkOrderEmail
    {
		public int Id { get; set; }
		public int WorkOrderId { get; set; }
        public int EmailType { get; set; }
        public System.DateTime Sent { get; set; }
    
        public WorkOrder WorkOrder { get; set; }
    }
}
