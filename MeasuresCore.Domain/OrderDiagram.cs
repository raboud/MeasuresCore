using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class OrderDiagram
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string DiagramNumber { get; set; }
        public Nullable<System.DateTime> DiagramDateTime { get; set; }
        public string DiagramFileName { get; set; }
    
        public Order Order { get; set; }
    }
}
