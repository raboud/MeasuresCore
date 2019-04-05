using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class WorkOrder
    {
        public int Id { get; set; }

        public bool Cancel { get; set; }
        public bool ScheduledAM { get; set; }

        [Date]
        public System.DateTime ScheduleEndDate { get; set; }

        [Date]
        public System.DateTime ScheduleStartDate { get; set; }

        public Nullable<int> CrewId { get; set; }
        public Nullable<int> JobId { get; set; }
        public Nullable<int> OrderId { get; set; }
    
        public List<BillDetail> BillDetails { get; set; }
        public InstallationCrew InstallationCrew { get; set; }
        public Order Order { get; set; }
        public List<WorkOrderEmail> WorkOrderEmails { get; set; }
        public List<Document> Documents { get; set; }
    }
}
