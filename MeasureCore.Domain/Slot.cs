using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Slot
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string UserId { get; set; }
        public int SlotTypeId { get; set; }
        public int MeasureId { get; set; }
    
        public AspNetUser User { get; set; }
        public Measure Measure { get; set; }
        public SlotType SlotType { get; set; }
    }
}
