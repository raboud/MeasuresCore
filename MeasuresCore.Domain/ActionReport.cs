using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class ActionReport
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Nullable<System.DateTime> ReportDate { get; set; }
        public string Nature { get; set; }
        public string ActionRequired { get; set; }
        public string Cause { get; set; }
        public Nullable<bool> Closed { get; set; }
        public Nullable<int> StoreError { get; set; }
        public Nullable<int> MillError { get; set; }
        public Nullable<int> InstallerError { get; set; }
        public Nullable<int> MeasureError { get; set; }
        public string StoreErrorText { get; set; }
        public string MillErrorText { get; set; }
        public string InstallerErrorText { get; set; }
        public string MeasureErrorText { get; set; }
        public Nullable<int> EnteredBy { get; set; }
        public Nullable<System.DateTime> LastEditedDate { get; set; }
        public Nullable<int> LastEditedBy { get; set; }
    
        public Order Order { get; set; }
    }
}
