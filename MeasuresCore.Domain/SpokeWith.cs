using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class SpokeWith
    {
        public int Id { get; set; }
        public string SW_Text { get; set; }
        public bool ShowAlways { get; set; }
        public byte DisplayOrder { get; set; }
        public bool EnableSchedulingInfo { get; set; }
    }
}
