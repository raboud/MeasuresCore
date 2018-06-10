using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class TechCapacity
    {
        public int Id { get; set; }
        public string TechId { get; set; }
        public int SlotTypeId { get; set; }
        public byte Capacity { get; set; }
        public byte DayOfWeek { get; set; }
    
        public SlotType SlotType { get; set; }
        public Tech Tech { get; set; }
    }
}
