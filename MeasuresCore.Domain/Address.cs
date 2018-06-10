using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
	[Owned]
	public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

		public Nullable<double> Latitude { get; set; }
		public Nullable<double> Longitude { get; set; }

	}
}