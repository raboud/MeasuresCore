using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
	public class DocumentOrder
	{
		public int OrderId { get; set; }
		public int DocumentId { get; set; }
		public bool Active { get; set; }
        public Document Document { get; set; }
        public Order Order { get; set; }
	}

    public class DocumentClient
    {
        public int OrderId { get; set; }
        public int DocumentId { get; set; }
        public bool Active { get; set; }
        public Document Document { get; set; }
        public Client Client { get; set; }
    }
}
