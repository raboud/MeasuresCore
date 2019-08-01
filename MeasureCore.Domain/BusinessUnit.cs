using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{

    public partial class BusinessUnit : WithParent<BusinessUnit>
	{
        public BusinessUnit()
        {
        }

        public int Id { get; set; }
        public override string Name { get; set; }
        public bool Active { get; set; }

    }
}
