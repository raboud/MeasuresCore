using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandREng.MeasuresCore.Domain
{
	public partial class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string NickName { get; set; }
		public Address Address { get; set; }
		public string HomeNumber { get; set; }
		public string MobileNumber { get; set; }
		public string PagerNumber { get; set; }
		public string SSN { get; set; }
		public string Email { get; set; }
		public Nullable<System.DateTime> HireDate { get; set; }
		public bool ReceiveCallNotes { get; set; }
		public string SMTPEmail { get; set; }
		public string UserName { get; set; }
		public bool Active { get; set; }

		public Admin Admin { get; set; }
		public List<Discrepancy> Discrepancies { get; set; }
		public List<Market> Markets { get; set; }
		public List<OrderItems> OrderBasicLaborDetails { get; set; }
		public List<OrderCustom> OrderCustomDetails { get; set; }
		public List<OrderOption> Order_Options_Details { get; set; }
		public List<OrderRegMerchandiseDetail> OrderRegMerchandiseDetails { get; set; }

		[InverseProperty("AssignedTo")]
		public List<Order> AssignedOrders { get; set; }

		[InverseProperty("CreatedBy")]
		public List<Order> CreatedOrders { get; set; }

		[InverseProperty("SalesPerson")]
		public List<Order> SalesOrders { get; set; }
		[InverseProperty("ReviewedBy")]
		public List<Order> ReviewedOrders { get; set; }
		public List<OrderSOMerchandiseDetail> OrderSOMerchandiseDetails { get; set; }
		public List<OrderNote> PONotes { get; set; }
		public List<Store> Stores { get; set; }
		public List<UserMarketDivisionAssignment> UserMarketDivisionAssignments { get; set; }
		public List<UserPermission> UserPermissions { get; set; }


		[InverseProperty("AssignedTo")]
		public List<UserTask> AssignedTasks { get; set; }
		[InverseProperty("CompletedBy")]
		public List<UserTask> CompletedTasks { get; set; }
		[InverseProperty("AddedBy")]
		public List<UserTask> AddedTasks { get; set; }
    }
}
