using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MaterialCost
    {
        public int Id { get; set; }
        public int MaterialCatId { get; set; }
		public Pricing Cost { get; set; }
        public MaterialCatagory MaterialCat { get; set; }
    }
}
