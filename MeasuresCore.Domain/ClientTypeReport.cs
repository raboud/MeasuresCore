using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class ClientTypeReport
    {
        public int Id { get; set; }
        public int ReportTypeId { get; set; }
        public int ClientTypeId { get; set; }
        public string Location { get; set; }
    
        public CustomerType StoreType { get; set; }
        public ReportType ReportType { get; set; }
    }
}
