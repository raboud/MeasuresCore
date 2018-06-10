using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class ReportType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
    
        public List<ClientTypeReport> ClientTypeReports { get; set; }
        public List<ProgramReport> ProgramReports { get; set; }
    }
}
