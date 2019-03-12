using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Admin
    {
		[Key]
        public int EmployeeId { get; set; }
    
        public Employee Employee { get; set; }
    }
}
