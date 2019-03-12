using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
	public class ItemPricing
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
		public Pricing Price { get; set; }
    
        public Item Item { get; set; }
    }

}

