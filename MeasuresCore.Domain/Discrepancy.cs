using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Discrepancy
    {
        public int Id { get; set; }
        public Nullable<int> DiscrepancyTypeId { get; set; }
        public Nullable<int> DiscrepancySubTypeId { get; set; }
        public string CurrentData { get; set; }
        public string NewData { get; set; }
        public string XMLFilePath { get; set; }
        public System.DateTime DateFound { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> DetailId { get; set; }
        public bool Reviewed { get; set; }
        public Nullable<int> ReviewedById { get; set; }
        public Nullable<System.DateTime> DateReviewed { get; set; }
    
        public DiscrepancyType DiscrepancyType { get; set; }
        public Employee ReviewedBy { get; set; }
        public Order Order { get; set; }
    }
}
