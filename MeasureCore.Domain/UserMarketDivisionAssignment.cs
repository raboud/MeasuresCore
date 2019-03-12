using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class UserMarketDivisionAssignment
    {
        public int Id { get; set; }
        public int ManagerId { get; set; }
        public int MarketId { get; set; }
        public int BusinessUnitId { get; set; }
    
        public BusinessUnit BusinessUnit { get; set; }
        public Employee Manager { get; set; }
        public Market Market { get; set; }
    }
}
