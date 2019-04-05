using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandREng.MeasuresCore.Domain
{
	public partial class Employee : Person
	{
        public Employee()
        {

        }
        public List<PhoneNumber> PhoneNumbers { get; set; }

		public int Id { get; set; }
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

		public List<Store> Stores { get; set; }
		public List<UserMarketDivisionAssignment> UserMarketDivisionAssignments { get; set; }
		public List<UserPermission> UserPermissions { get; set; }

    }
}
