using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RandREng.Types
{
    public class MoneyAttribute : ColumnAttribute
    {
		public MoneyAttribute() : base()
		{
			this.TypeName = "Money";
		}

		public MoneyAttribute(string name) : base(name)
		{
			this.TypeName = "Money";
		}
	}

	public class DateAttribute : ColumnAttribute
	{
		public DateAttribute() : base()
		{
			this.TypeName = "Date";
		}

		public DateAttribute(string name) : base(name)
		{
			this.TypeName = "Date";
		}
	}
}
