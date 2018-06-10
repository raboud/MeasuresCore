using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class OrderCustom
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Nullable<int> SubContractorId { get; set; }

		[Money]
		public Nullable<decimal> RetailPrice { get; set; }
		[Money]
		public decimal UnitCost { get; set; }
		[Money]
		public decimal UnitPrice { get; set; }
		[Money]
		public decimal ExtendedPrice { get; set; }
		[Money]
		public decimal ExtendedCost { get; set; }

		public double Quanity { get; set; }
        public Nullable<int> UnitOfMeasureId { get; set; }
        public Nullable<bool> NotOnInvoice { get; set; }
        public Nullable<bool> NotOnWorkOrder { get; set; }
        public Nullable<bool> SubContractorPaid { get; set; }
        public Nullable<double> SubContractorPay { get; set; }
        public int EntryMethodId { get; set; }
        public Nullable<int> CustomItemNumber { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public bool Reviewed { get; set; }
        public Nullable<int> ReviewedById { get; set; }
        public Nullable<System.DateTime> ReviewedDate { get; set; }
        public bool PrintOnWorkOrder { get; set; }
        public bool PrintOnInvoice { get; set; }
    
        public Employee Employee { get; set; }
        public EntryMethod EntryMethod { get; set; }
        public Order Order { get; set; }
        public SubContractor SubContractor { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }
    }
}
