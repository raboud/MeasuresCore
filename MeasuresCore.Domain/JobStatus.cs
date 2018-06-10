using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class JobStatus
    {
        public int Id { get; set; }
        public string JobStatusDescription { get; set; }
    
        public List<Order> Orders { get; set; }
    }
}
