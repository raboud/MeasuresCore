using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
	[Owned]
	public class Address
    {
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

		public Nullable<double> Latitude { get; set; }
		public Nullable<double> Longitude { get; set; }

	}
}
