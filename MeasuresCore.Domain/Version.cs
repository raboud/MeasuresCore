using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Version
    {
        public int VersionId { get; set; }
        public Nullable<int> VersionNo { get; set; }
        public Nullable<int> MinimumVersionMajor { get; set; }
        public Nullable<int> MinimumVersionMinor { get; set; }
    }
}
