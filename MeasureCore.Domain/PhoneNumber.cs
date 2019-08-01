using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandREng.MeasuresCore.Domain
{
	[Owned]
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int PhoneNumberTypeId { get; set; }
        public PhoneNumberType PhoneNumberType { get; set; }

		public bool Active { get; set; }
    }
}
