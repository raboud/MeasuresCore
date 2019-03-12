using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class SubContractorsDivisionAssignment
    {
        public int Id { get; set; }
        public int SubContractorId { get; set; }
        public int DivisionId { get; set; }
        public Nullable<int> SubDivisionId { get; set; }
    }
}
