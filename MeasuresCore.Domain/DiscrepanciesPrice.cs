using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class DiscrepanciesPrice
    {
        public int Id { get; set; }
        public int DiscrepancyTypeId { get; set; }
        public int ItemId { get; set; }
        public int MarketId { get; set; }
		[Money]
        public Nullable<decimal> CurrentPrice { get; set; }
		[Money]
		public Nullable<decimal> NewPrice { get; set; }
        public string XMLFilePath { get; set; }
        public System.DateTime DateFound { get; set; }
    }
}
