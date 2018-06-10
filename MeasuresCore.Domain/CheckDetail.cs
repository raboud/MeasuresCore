using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class CheckDetail
    {
        public int Id { get; set; }
        public int CheckId { get; set; }
        public int OrderId { get; set; }
		[Money]
        public decimal Amount { get; set; }
    
        public Check Check { get; set; }
        public Order Order { get; set; }
    }
}
