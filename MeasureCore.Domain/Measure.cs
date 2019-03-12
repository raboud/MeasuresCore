using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Measure
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime Enterred { get; set; }
        public int StoreId { get; set; }
        public string EnterredById { get; set; }
        public string SpecialInstructions { get; set; }
        public bool Deleted { get; set; }
        public Status Status { get; set; }
    
        public Store Store { get; set; }
        public List<MeasureEmail> Emails { get; set; }
        public List<MeasureMaterial> Materials { get; set; }
        public AspNetUser EnterredBy { get; set; }
        public Client Customer { get; set; }
        public List<Slot> Slots { get; set; }
    }
}
