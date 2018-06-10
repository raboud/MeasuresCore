using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class SPNActionQueue
    {
        public int Id { get; set; }
        public int ActionId { get; set; }
        public string DataField1 { get; set; }
        public string DataField2 { get; set; }
        public string DataField3 { get; set; }
        public string DataField4 { get; set; }
        public Nullable<System.DateTime> SendAfter { get; set; }
        public bool Processed { get; set; }
    
        public SPNAction SPNAction { get; set; }
    }
}
