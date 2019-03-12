using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Week
    {
		[Key]
        public int Weeks { get; set; }
    }
}
