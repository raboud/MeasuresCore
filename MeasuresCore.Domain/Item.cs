using RandREng.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandREng.MeasuresCore.Domain
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string WorkOrderDescription { get; set; }

		public Nullable<int> UnitOfMeasureId { get; set; }

		public bool PrintOnWO { get; set; }
		public Nullable<bool> PrintOnInvoice { get; set; }

		public bool Active { get; set; }
		public bool Size { get; set; }
		public bool JobSize { get; set; }

		public bool ApplyToMinimun { get; set; }
        public bool ApplyToMinimumWO { get; set; }

		[Money]
		public Nullable<decimal> UnitPrice { get; set; }
		[Money]
		public Nullable<decimal> UnitCost { get; set; }
		[Money]
		public Nullable<decimal> RetailPrice { get; set; }

		public int ProgramId { get; set; }

		public Nullable<int> ParentId { get; set; }

		public UnitOfMeasure UnitOfMeasure { get; set; }
		public Item Parent { get; set; }

		[InverseProperty("Parent")]
		public List<Item> SubItems { get; set; }

		public Program Program { get; set; }

		public List<ItemCosting> ItemCosts { get; set; }
		public List<ItemPricing> ItemPrices { get; set; }
        public List<ItemMatCosting> ItemMatCosts { get; set; }
		public List<ItemRetailPricing> ItemRetailPrices { get; set; }
		public List<MaterialCatagory> MaterialCatagories { get; set; }
    }
}
