using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Program
    {
        public Program()
        {
            //this.BasicLabors = new HashSet<BasicLabor>();
            //this.MaterialCosts = new HashSet<MaterialCost>();
            //this.MaterialPrices = new HashSet<MaterialPrice>();
            //this.MaterialTypesMarketMappings = new HashSet<ProgramMarketMapping>();
            //this.Options = new HashSet<Option>();
            //this.Orders = new HashSet<Order>();
            //this.ProgramReports = new HashSet<ProgramReport>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CustomerTypeId { get; set; }
		[Money]
        public Nullable<decimal> MinimumPrice { get; set; }
		[Money]
		public Nullable<decimal> MinimumCost { get; set; }
		[Money]
		public Nullable<decimal> MinimumRetail { get; set; }

		public Nullable<double> CustomMultiplier { get; set; }
        public Nullable<double> TripChargeMultiplier { get; set; }
        public Nullable<double> CostMultiplier { get; set; }
        public Nullable<bool> Valid { get; set; }
        public Nullable<bool> OnlyBasicToMinimum { get; set; }
        public string ShortName { get; set; }
        public Nullable<int> BusinesUnitId { get; set; }
        public Nullable<bool> Active { get; set; }
        public bool Furnish { get; set; }
        public string SKU { get; set; }
        public string SKUDesc { get; set; }
        public string HDType { get; set; }
        public string MaterialTypeName { get; set; }
        public bool InsuranceReplacement { get; set; }
        public bool AllowMaterialStatusUpdate { get; set; }
        public Nullable<int> JobTypeId { get; set; }
        public bool WoodWaiver { get; set; }
        public bool CustomCostByRetail { get; set; }
        public Nullable<int> MarkDown { get; set; }
        public Nullable<int> MarkDownMin { get; set; }
        public Nullable<int> MarkDownMax { get; set; }
    
        public BusinessUnit BusinessUnit { get; set; }
        public CustomerType CustomerType { get; set; }
    }
}
