using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class DepartmentsContactTitle
    {
        public int DepartmentsId { get; set; }
        public int ContactTitlesId { get; set; }
        public Nullable<bool> Required { get; set; }
    
        public ContactTitle ContactTitle { get; set; }
        public Department Department { get; set; }
    }
}
