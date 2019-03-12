using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class ItemMatCosting
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
		public Pricing MatCost { get; set; }
    
        public Item Item { get; set; }
    }
}
