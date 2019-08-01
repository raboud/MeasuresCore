using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandREng.MeasuresCore.Domain
{
	public partial class Employee : Person
	{
        public Employee()
        {
			this.PhoneNumbers = new List<PhoneNumber>();
			this.Permissions = new List<UserPermission>();
			this.Clients = new List<Client>();
			this.Assignments = new List<UserMarketDivisionAssignment>();
        }

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

		public virtual List<Client> Clients { get; set; }
		public virtual List<UserMarketDivisionAssignment> Assignments { get; set; }
		public virtual List<UserPermission> Permissions { get; set; }
		public virtual List<PhoneNumber> PhoneNumbers { get; set; }

	}
}
