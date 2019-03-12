using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class ProgramMarketMapping
    {
        public int ProgramId { get; set; }
        public int MarketId { get; set; }
        public bool AllowEntry { get; set; }
    
        public Market Market { get; set; }
        public Program Program { get; set; }
    }
}
