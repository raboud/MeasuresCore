using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Width
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public int MaterialTypeId { get; set; }
    }
}
