using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public class InstallationCrewType
    {
        public int InstallationCrewId { get; set; }
        public int JobTypeId { get; set; }
        public Nullable<double> Rating { get; set; }
        public Nullable<int> MaxSizeId { get; set; }
    
        public InstallationCrew InstallationCrew { get; set; }
        public JobType JobType { get; set; }
    }
}
