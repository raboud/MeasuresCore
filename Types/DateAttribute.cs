using System.ComponentModel.DataAnnotations.Schema;

namespace RandREng.Types
{
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
