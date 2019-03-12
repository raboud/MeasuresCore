using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RandREng.Types
{

	public class PhoneNumber10 : RegularExpressionAttribute
	{
		public PhoneNumber10()
			: base(RegEx)
		{
			base.ErrorMessage = "Phone number in form of (123) 456-7890";
		}

		public const string RegEx = @"^\(?(\d{3})\)?[ |\-|\.]?(\d{3})[ |\-|\.]?(\d{4})$";

		public override bool IsValid(object value)
		{
			return base.IsValid(value);
		}

		public static string Reformat(string input)
		{
			string a = string.Empty;
			if (input != null)
			{
				input = input.Trim();

				if (!string.IsNullOrEmpty(input))
				{
					try
					{
						a = "ERROR";
						Regex reg = new Regex(RegEx);
						Match m = reg.Match(input);
						if (m.Groups.Count == 4)
						{
							a = string.Format("({0}) {1}-{2}", m.Groups[1].Value, m.Groups[2].Value, m.Groups[3].Value);
						}
					}
					catch (Exception)
					{

					}
				}
			}
			return a;
		}
	}
}
