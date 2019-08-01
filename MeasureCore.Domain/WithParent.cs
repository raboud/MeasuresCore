using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RandREng.MeasuresCore.Domain
{
	public interface IWithParent<T> where T : class
	{
		int? ParentId { get; set; }
		T Parent { get; set; }
		string Name { get; set; }
		ICollection<T> Childrens { get; set; }

		string FullName { get; }

	}

	public abstract class WithParent<T> : IWithParent<T> where T : class
	{
		public WithParent()
		{
			this.Childrens = new HashSet<T>();
		}
		public int? ParentId { get; set; }
		public virtual T Parent { get; set; }
		public virtual ICollection<T> Childrens { get; set; }

		[NotMapped]
		public string FullName => (this.Parent != null ? ((IWithParent<T>) this.Parent).FullName + " - " : "") + this.Name;

		public virtual string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
