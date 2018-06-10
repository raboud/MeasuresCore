using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
	public class OrderDocument
	{
		public int OrderId { get; set; }
		public int DocumentId { get; set; }
		public bool Active { get; set; }
		public Order Order { get; set; }
		public Document Document { get; set; }

	}
}
