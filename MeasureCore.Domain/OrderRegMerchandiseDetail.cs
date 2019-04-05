using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class OrderRegMerchandiseDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string SKUNumber { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<int> UnitOfMeasureId { get; set; }
        public bool Deleted { get; set; }
        public int EntryMethodId { get; set; }
        public Nullable<int> MaterialStatusId { get; set; }
        public Nullable<int> TransferredTo { get; set; }
        public Nullable<int> TransferredFrom { get; set; }
        public WhoDidIt Reviewed { get; set; }
        public Nullable<int> OriginalOrderId { get; set; }
        public string Notes { get; set; }

        public EntryMethod EntryMethod { get; set; }
        public MaterialStatus Material_Status { get; set; }
        public Order Order { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }

        [Money]
        public Nullable<decimal> Price { get; set; }
		[Money]
        public Nullable<decimal> Retail { get; set; }

    
    }
}
