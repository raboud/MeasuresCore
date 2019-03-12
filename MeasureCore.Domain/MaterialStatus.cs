using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MaterialStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public bool Billable { get; set; }
        public bool Installable { get; set; }
    
        public List<OrderItems> OrderBasicLaborDetails { get; set; }
        public List<OrderRegMerchandiseDetail> OrderRegMerchandiseDetails { get; set; }
        public List<OrderSOMerchandiseDetail> OrderSOMerchandiseDetails { get; set; }
    }
}
