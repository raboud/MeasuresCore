using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    
    public partial class BusinessUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentId { get; set; }
        public bool PrintStatusReport { get; set; }
        public bool MarkBilledWhenPaid { get; set; }
        public bool Active { get; set; }
        public Nullable<int> VendorId { get; set; }
		public BusinessUnit Parent { get; set; }
	}
}
