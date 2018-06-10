using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class StoreContact
    {
        public int Id { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> TitleId { get; set; }
        public string PhoneNumber { get; set; }
        public string AltPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool EmailStatusReport { get; set; }
        public bool EmailBilling { get; set; }
        public bool EmailNotes { get; set; }
    
        public Department Department { get; set; }
        public Store Store { get; set; }
    }
}
