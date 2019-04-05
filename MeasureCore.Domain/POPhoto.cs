using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class POPhoto
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public WhoDidIt EnterredBy { get; set; }
        public int OrderId { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime DateTimeEntered { get; set; }
        public string Title { get; set; }
    
        public Order Order { get; set; }
    }
}
