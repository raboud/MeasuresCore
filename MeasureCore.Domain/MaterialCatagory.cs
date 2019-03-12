using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MaterialCatagory
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsPadding { get; set; }
        public Nullable<int> YardsPerRoll { get; set; }
        public int UnitOfMeasureId { get; set; }
        public Nullable<int> SubCatId { get; set; }
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public string Style { get; set; }
        public string SKU { get; set; }
        public bool Furnish { get; set; }
        public bool Active { get; set; }
    
        public MatSubCat MatSubCat { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }
        public List<MaterialCost> MaterialCosts { get; set; }
        public List<MaterialPrice> MaterialPrices { get; set; }
//        public List<BasicLabor> BasicLabors { get; set; }
//        public List<Item> Items { get; set; }
//        public List<Option> Options { get; set; }
    }
}
