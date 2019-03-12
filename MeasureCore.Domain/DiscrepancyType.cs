using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class DiscrepancyType
    {
        public int Id { get; set; }
        public string Description { get; set; }
    
        public List<Discrepancy> Discrepancies { get; set; }
    }
}
