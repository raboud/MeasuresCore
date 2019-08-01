using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
	public partial class ItemCosting
	{
		public int Id { get; set; }
		public int ItemId { get; set; }
		public Pricing Cost {get;set;}

//		public Item Item { get; set; }
	}
}
