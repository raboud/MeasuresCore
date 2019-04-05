using RandREng.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandREng.MeasuresCore.Domain
{
	public partial class Order
    {
		public Order()
		{
			this.OrdersDocuments = new List<DocumentOrder>();
		}
		public int Id { get; set; }
        public int CustomerId { get; set; }
        public Address Address { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string Notes { get; set; }
		[Date]
        public Nullable<System.DateTime> ScheduleStartDate { get; set; }
        public Nullable<System.DateTime> BilledDate { get; set; }
        public bool Scheduled { get; set; }
        public bool Billed { get; set; }
        public bool Paid { get; set; }
        public bool Called { get; set; }
		public int ProgramId { get; set; }
		public string InternalNotes { get; set; }

		[Money]
		public decimal CostAmount { get; set; }
		[Money]
		public decimal BilledAmount { get; set; }
		[Money]
		public decimal OrderAmount { get; set; }
		[Money]
		public decimal TripCharge { get; set; }
		[Money]
		public decimal RetailAmount { get; set; }

		public bool NoMinimum { get; set; }
        public bool ScheduledAM { get; set; }
        public bool Cancelled { get; set; }
        public bool Warrenty { get; set; }
        public int StoreId { get; set; }
        public bool SevenDay { get; set; }
        public string DrawingNumber { get; set; }
        public Nullable<System.DateTime> DrawingDate { get; set; }
        public bool CustomerToCall { get; set; }
        public bool Invoice { get; set; }
        public string OriginalPO { get; set; }
        public string OrderNo { get; set; }
        public int EntryMethodId { get; set; }

        public WhoDidIt Assigned { get; set; }
        public WhoDidIt Created { get; set; }
        public WhoDidIt Entered { get; set; }
        public WhoDidIt Reviewed { get; set; }

        public Nullable<System.DateTime> FollowUpDate { get; set; }
        public string FollowUpAction { get; set; }
        public string SPNNotes { get; set; }
        public int XMLOrderCostAmount { get; set; }
        public bool Deleted { get; set; }
        public Nullable<int> VendorId { get; set; }
        public string CustomerOrderNumber { get; set; }
        public Nullable<System.DateTime> SvcCompleteSentDate { get; set; }
        public Nullable<System.DateTime> ScheduleEndDate { get; set; }
        public Nullable<int> SalesPersonId { get; set; }
        public bool Estimate { get; set; }
        public string NUMBER { get; set; }
        public Nullable<int> JobId { get; set; }
        public Nullable<int> MarkDown { get; set; }
        public Nullable<double> JobSize { get; set; }
        public Nullable<int> JobStatusId { get; set; }
        public Nullable<int> PrimaryOrderId { get; set; }
    
        public List<ActionReport> ActionReports { get; set; }
        public List<ChargeBack> ChargeBacks { get; set; }
        public List<CheckDetail> CheckDetails { get; set; }
        public Client Customer { get; set; }
        public List<Discrepancy> Discrepancies { get; set; }
        public EntryMethod EntryMethod { get; set; }
        public Program Program { get; set; }
        public List<OrderItems> Items { get; set; }
        public List<OrderRegMerchandiseDetail> OrderRegMerchandiseDetails { get; set; }
        public List<OrderSOMerchandiseDetail> OrderSOMerchandiseDetails { get; set; }
        public List<OrderCustom> OrderCustomDetails { get; set; }
        public List<OrderDiagram> OrderDiagrams { get; set; }
        public List<Order> Orders { get; set; }
        public Order PrimaryOrder { get; set; }

        public List<OrderNote> PONotes { get; set; }
        public List<POPhoto> POPhotos { get; set; }
        public List<UserTask> UserTasks { get; set; }
        public List<WorkOrder> WorkOrders { get; set; }

		public List<DocumentOrder> OrdersDocuments { get; set; } 
	}
}
