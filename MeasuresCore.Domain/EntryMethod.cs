using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class EntryMethod
    {
        public int Id { get; set; }
        public string Description { get; set; }
    
        public List<OrderItems> OrderBasicLaborDetails { get; set; }
        public List<OrderCustom> OrderCustomDetails { get; set; }
        public List<OrderOption> Order_Options_Details { get; set; }
        public List<OrderRegMerchandiseDetail> OrderRegMerchandiseDetails { get; set; }
        public List<Order> Orders { get; set; }
        public List<OrderSOMerchandiseDetail> OrderSOMerchandiseDetails { get; set; }
    }
}
