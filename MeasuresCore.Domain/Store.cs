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
	public class Store2
	{
		public Store2()
		{
			//this.BasicCosts = new HashSet<BasicCost>();
			//this.BasicPrices = new HashSet<BasicPrice>();
			//this.BasicRetails = new HashSet<BasicRetail>();
			//this.DepartmentsStoresAssignments = new HashSet<DepartmentsStoresAssignment>();
			//this.ItemCostings = new HashSet<ItemCosting>();
			//this.ItemMatCostings = new HashSet<ItemMatCosting>();
			//this.ItemPricings = new HashSet<ItemPricing>();
			//this.MaterialCosts = new HashSet<MaterialCost>();
			//this.MaterialPrices = new HashSet<MaterialPrice>();
			//this.OptionCosts = new HashSet<OptionCost>();
			//this.OptionPrices = new HashSet<OptionPrice>();
			//this.OptionRetails = new HashSet<OptionRetail>();
			//this.StoreContacts = new HashSet<StoreContact>();
		}

		public int Id { get; set; }
//		public int StoreTypeId { get; set; }
		public string StoreNumber { get; set; }

		public Address Address { get; set; }
		public Address BillingAddress { get; set; }

		public string StorePhoneNumber { get; set; }
		public string DirectPhoneNumber { get; set; }
		public string Extension { get; set; }
		public string FaxNumber { get; set; }
		public string Notes { get; set; }
		public int MarketId { get; set; }
		public bool Active { get; set; }
		public string StoreNickName { get; set; }
		public Nullable<short> MarketNumber { get; set; }
		public int XMLSourceId { get; set; }
		public bool IncludeInStatusReportAll { get; set; }
		//public Nullable<int> AccountRepId { get; set; }
		//public Nullable<int> AccountCoorId { get; set; }

		//public List<DepartmentsStoresAssignment> DepartmentsStoresAssignments { get; set; }
		//public Employee Employee { get; set; }
		//public Employee Employee1 { get; set; }
		public List<ItemCosting> ItemCostings { get; set; }
		public List<ItemMatCosting> ItemMatCostings { get; set; }
		public List<ItemPricing> ItemPricings { get; set; }
		public Market Market { get; set; }
		//public List<MaterialCost> MaterialCosts { get; set; }
		//public List<MaterialPrice> MaterialPrices { get; set; }
		//public List<StoreContact> StoreContacts { get; set; }
		public StoreType StoreType { get; set; }
	}
}
