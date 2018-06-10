using System;
using System.Collections.Generic;


namespace RandREng.MeasuresCore.Domain
{
    public partial class SlotType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    
        public List<TechCapacity> TechCapacities { get; set; }
        public List<Slot> Slots { get; set; }
    }
}
