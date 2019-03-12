namespace RandREng.MeasuresCore.Domain
{
	public class ItemRetailPricing
	{
		public int Id { get; set; }
		public int ItemI { get; set; }
		public Pricing Retail { get; set; }

		public Item Item { get; set; }
	}

}

