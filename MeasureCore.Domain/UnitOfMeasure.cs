using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class UnitOfMeasure
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Divisor { get; set; }
        public Nullable<int> NumberOfDecimals { get; set; }
        public string LongDescription { get; set; }
        public string LongDescriptionSOSI { get; set; }
    }
}
