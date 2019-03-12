using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MatSubCat
    {
        public int Id { get; set; }
        public string Description { get; set; }
    
        public List<MaterialCatagory> MaterialCatagory { get; set; }
    }
}
