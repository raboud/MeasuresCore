using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class ProgramReport
    {
        public int Id { get; set; }
        public int ReportTypeId { get; set; }
        public int ProgramId { get; set; }
        public string Name { get; set; }
    
        public Program Program { get; set; }
        public ReportType ReportType { get; set; }
    }
}
