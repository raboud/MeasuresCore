using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MeasureCompOrderData
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Nullable<bool> Heat { get; set; }
        public Nullable<bool> Pets { get; set; }
        public Nullable<bool> Electricity { get; set; }
        public Nullable<bool> FurnitureMoving { get; set; }
        public Nullable<bool> NewPaint { get; set; }
        public Nullable<bool> Removal { get; set; }
        public Nullable<bool> PavedDriveway { get; set; }
        public Nullable<bool> Garage { get; set; }
        public Nullable<bool> Elevator { get; set; }
        public string Disposal { get; set; }
        public string Access { get; set; }
        public string SiteType { get; set; }
        public string MetalColor { get; set; }
    
        public Order Order { get; set; }
    }
}
