using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class UnitOfMeasure
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Divisor { get; set; }
    }
}
