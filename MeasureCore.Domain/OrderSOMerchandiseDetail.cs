using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class OrderSOMerchandiseDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string SONumber { get; set; }
        public string SKUNumber { get; set; }
        public Nullable<int> ItemId { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<int> UOMId { get; set; }
        public Nullable<System.DateTime> ExpectedArrivalDate { get; set; }
        public Nullable<int> SOLineNumber { get; set; }
        public Nullable<int> MaterialStatusId { get; set; }
        public int EntryMethodId { get; set; }
        public bool Deleted { get; set; }
        public Nullable<int> TransferredTo { get; set; }
        public Nullable<int> TransferredFrom { get; set; }
        public Nullable<int> SOMerLineNumber { get; set; }
        public Nullable<int> OriginalId { get; set; }
        public Nullable<double> PreSplitQty { get; set; }
        public Nullable<int> XMLStatusId { get; set; }
        public bool Reviewed { get; set; }
        public Nullable<int> ReviewedById { get; set; }
        public Nullable<System.DateTime> ReviewedDate { get; set; }
        public Nullable<int> WillCallLineNumber { get; set; }
        public Nullable<int> OriginalOrderId { get; set; }
        public bool NotNeeded { get; set; }
        public Nullable<System.DateTime> Received { get; set; }
    
        public Employee ReviewedBy { get; set; }
        public EntryMethod EntryMethod { get; set; }
        public MaterialStatus Material_Status { get; set; }
        public Order Order { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }
        public List<Document> Documents { get; set; }
    }
}
