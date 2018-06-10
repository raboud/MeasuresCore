using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class StatusDetail
    {
        public string StoreNumber { get; set; }
        public string PONumber { get; set; }
        public Nullable<int> POGroup { get; set; }
        public Nullable<int> DivisionId { get; set; }
        public Nullable<int> DivisionGroupId { get; set; }
        public Nullable<bool> InsuranceReplacement { get; set; }
        public Nullable<int> LineIndex { get; set; }
        public string LineString { get; set; }
    }
}
