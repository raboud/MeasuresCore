using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class BillClassification
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool SubjectToRetainage { get; set; }
        public bool SubjectToInsurance { get; set; }
    }
}
