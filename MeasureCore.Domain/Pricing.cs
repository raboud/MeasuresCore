using Microsoft.EntityFrameworkCore;
using RandREng.Types;
using System;

namespace RandREng.MeasuresCore.Domain
{
	[Owned]
	public class Pricing
	{
		public Nullable<int> MarketId { get; set; }
		public Nullable<int> StoreId { get; set; }

		[Money]
		public decimal Amount { get; set; }
		[Money]
		public Nullable<decimal> Freight { get; set; }

		[Date]
		public System.DateTime StartDate { get; set; }
		[Date]
		public Nullable<System.DateTime> EndDate { get; set; }

		public Nullable<int> BusinessUnitId { get; set; }
		public Nullable<double> SalesTax { get; set; }


		public BusinessUnit BusinessUnit { get; set; }
		public Market Market { get; set; }
		public Client Store { get; set; }
	}
}
