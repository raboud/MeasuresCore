using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MeasureCompCalcData
    {
        public int Id { get; set; }
        public int OrderId{ get; set; }
        public System.DateTime CalcTimeStamp { get; set; }
        public Nullable<bool> Assigned { get; set; }
    
        public Order Order { get; set; }
        public List<MeasureCompLineItemData> MeasureCompLineItemDatas { get; set; }
    }
}
