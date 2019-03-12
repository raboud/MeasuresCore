using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
	public class Store
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Address Address { get; set; }
		public Address BillingAddress { get; set; }

	}
}
