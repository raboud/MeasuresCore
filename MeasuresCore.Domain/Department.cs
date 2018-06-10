using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    
        public List<DepartmentsContactTitle> DepartmentsContactTitles { get; set; }
        public List<DepartmentsStoresAssignment> DepartmentsStoresAssignments { get; set; }
        public List<StoreContact> StoreContacts { get; set; }
    }
}
