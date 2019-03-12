using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RandREng.MeasuresCore.Domain
{
	public partial class DaysOfYear
    {
		[Key]
        public System.DateTime DateValue { get; set; }
    }
}
