using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class CheckCBDetail
    {
        public int Id { get; set; }
        public int CheckId { get; set; }
        public int ChargeBackId { get; set; }
		[Money]
		public decimal Amount { get; set; }
    
        public ChargeBack ChargeBack { get; set; }
        public Check Check { get; set; }
    }
}
