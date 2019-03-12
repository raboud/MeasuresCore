using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MeasureMaterial
    {
        public int Id { get; set; }
        public int MaterialTypeId { get; set; }
        public int MeasureId { get; set; }
        public Nullable<int> WidthId { get; set; }
        public Nullable<int> AltWidthId { get; set; }
        public string Description { get; set; }
        public Nullable<double> PatternMatchLength { get; set; }
        public Nullable<double> PatternMatchWidth { get; set; }
        public bool Deleted { get; set; }
    
        public Program MaterialType { get; set; }
        public Width AltWidth { get; set; }
        public Width Width { get; set; }
        public List<MeasureRoom> Rooms { get; set; }
    }
}
