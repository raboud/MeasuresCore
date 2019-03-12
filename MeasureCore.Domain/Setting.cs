using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Nullable<int> UserId { get; set; }
    }
}
