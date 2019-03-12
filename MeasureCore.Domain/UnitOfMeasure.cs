using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class UnitOfMeasure
    {
        public UnitOfMeasure()
        {
//            this.BasicLabors = new HashSet<BasicLabor>();
//            this.Items = new HashSet<Item>();
//            this.Material_Catagory = new HashSet<Material_Catagory>();
//            this.Options = new HashSet<Option>();
//            this.OrderCustomDetails = new HashSet<OrderCustom>();
//            this.OrderRegMerchandiseDetails = new HashSet<OrderRegMerchandiseDetail>();
//            this.OrderSOMerchandiseDetails = new HashSet<OrderSOMerchandiseDetail>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public int Divisor { get; set; }
        public Nullable<int> NumberOfDecimals { get; set; }
        public string LongDescription { get; set; }
        public string LongDescriptionSOSI { get; set; }
    
        //public List<BasicLabor> BasicLabors { get; set; }
        //public List<Item> Items { get; set; }
        //public List<Material_Catagory> Material_Catagory { get; set; }
        //public List<Option> Options { get; set; }
        //public List<OrderCustom> OrderCustomDetails { get; set; }
        //public List<OrderRegMerchandiseDetail> OrderRegMerchandiseDetails { get; set; }
        //public List<OrderSOMerchandiseDetail> OrderSOMerchandiseDetails { get; set; }
    }
}
