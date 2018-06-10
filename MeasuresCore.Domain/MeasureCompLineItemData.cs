using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MeasureCompLineItemData
    {
        public int Id { get; set; }
        public int CalcId { get; set; }
        public int LineItemNumber { get; set; }
        public string MaterialType { get; set; }
        public string MaterialDescription { get; set; }
        public Nullable<int> MaterialWidth { get; set; }
        public string PatternMatch { get; set; }
        public string MaterialAmount { get; set; }
    
        public MeasureCompCalcData MeasureCompCalcData { get; set; }
    }
}
