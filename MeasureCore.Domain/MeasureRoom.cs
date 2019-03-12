using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MeasureRoom
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string Name { get; set; }
        public int MaterialId { get; set; }
        public bool IncludeCloset { get; set; }
    
        public  Room Room{ get; set; }
    }
}
