using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class DepartmentsStoresAssignment
    {
        public int Id { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string FaxNumber { get; set; }
        public string Notes { get; set; }
        public string AltFaxNumber { get; set; }
        public Nullable<int> FaxStatusReportTo { get; set; }
    
        public Department Department { get; set; }
        public Store Store { get; set; }
    }
}
