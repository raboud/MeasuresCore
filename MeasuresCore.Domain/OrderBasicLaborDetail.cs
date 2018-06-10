using RandREng.Types;
using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class OrderItems
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }

        public double InstallQuantity { get; set; }

		[Money]
		public decimal UnitCost { get; set; }
		[Money]
		public decimal UnitPrice { get; set; }
		[Money]
		public Nullable<decimal> UnitRetail { get; set; }
		[Money]
		public decimal MaterialCost { get; set; }
		[Money]
		public decimal ExtendedPrice { get; set; }
		[Money]
		public decimal ExtendedCost { get; set; }

		public Nullable<int> SubContractorId { get; set; }

		public bool PrintOnInvoice { get; set; }
        public bool PrintOnWO { get; set; }
		public int EntryMethodId { get; set; }
		public Nullable<int> ReviewedById { get; set; }
		public Nullable<System.DateTime> ReviewedDate { get; set; }

		public Nullable<bool> SubContractorPaid { get; set; }
		[Money]
		public Nullable<Decimal> SubContractorPay { get; set; }

		public Nullable<int> ServiceLineNumber { get; set; }
        public Nullable<int> MaterialStatusId { get; set; }
        public bool Deleted { get; set; }
        public bool Reviewed { get; set; }
    
        public Item Item { get; set; }
        public Employee ReviewedBy { get; set; }
        public EntryMethod EntryMethod { get; set; }
        public MaterialStatus MaterialStatus { get; set; }
        public Order Order { get; set; }
    }
}
