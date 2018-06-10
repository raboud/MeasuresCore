using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class InstallationCrew
    {
		public InstallationCrew()
		{
			this.InstallationCrewType = new List<InstallationCrewType>();
		}
		public int Id { get; set; }
        public string CrewName { get; set; }
        public int OwnerId { get; set; }
        public int LeadId { get; set; }
        public int BranchId { get; set; }
        public bool Active { get; set; }
        public bool InstallationManager { get; set; }
    
        public Market Market { get; set; }
        public SubContractor Owner { get; set; }
        public SubContractor Lead { get; set; }
        public List<InstallationCrewType> InstallationCrewType { get; set; }
        public List<WorkOrder> WorkOrders { get; set; }
    }
}
