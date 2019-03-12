using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Market
    {
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public string PrinterName { get; set; }
        public string PrinterPort { get; set; }
        public string PrinterDriver { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public bool Active { get; set; }
    
        public Employee Employee { get; set; }
        //public List<InstallationCrew> InstallationCrews { get; set; }
        public List<ItemCosting> ItemCostings { get; set; }
        public List<ItemMatCosting> ItemMatCostings { get; set; }
        public List<ItemPricing> ItemPricings { get; set; }
        public List<MaterialCost> MaterialCosts { get; set; }
        public List<MaterialPrice> MaterialPrices { get; set; }
        //public List<ProgramMarketMapping> MaterialTypesMarketMappings { get; set; }
        public List<Store> Stores { get; set; }
        //public List<UserMarketDivisionAssignment> UserMarketDivisionAssignments { get; set; }
        //public List<UserPermission> UserPermissions { get; set; }
    }
}
