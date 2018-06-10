using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MaterialPrice
    {
        public int Id { get; set; }
        public int MaterialCatId { get; set; }
		public Pricing Price { get; set; }

		public MaterialCatagory Material_Catagory { get; set; }
    }
}
