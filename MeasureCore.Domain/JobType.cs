using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class JobType
    {
		public JobType()
		{
			this.InstallationCrewType = new List<InstallationCrewType>();
		}

        public int Id { get; set; }
        public string Description { get; set; }
        public bool AlwaysSkipInitialCall { get; set; }
    
        public List<InstallationCrewType> InstallationCrewType { get; set; }
        public List<Program> Programs { get; set; }
    }
}
