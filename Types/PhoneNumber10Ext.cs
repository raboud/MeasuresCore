﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RandREng.Types
{
	public class PhoneNumber10Ext : RegularExpressionAttribute
	{
		public PhoneNumber10Ext()
			: base(@"^\(?(\d{3})\)?[ |\-|\.]?(\d{3})[ |\-|\.]?(\d{4})(?:[\-\.\ \\\/]?(?:#|ext\.?|extension|x)[\-\.\ \\\/]?(\d+))?$")
		{
			base.ErrorMessage = "Phone number in form of (123) 456-7890 [ext 12345]";
		}

		public const string RegEx = @"^\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4})((?:#|ext\.?|extension|x)(\d+))?$";

		public static string Reformat(string input)
		{
			string a = string.Empty;
			if (input != null)
			{

				if (!string.IsNullOrEmpty(input))
				{
					try
					{
						a = "ERROR";
						Regex reg = new Regex(RegEx);
						Match m = reg.Match(input);
						if (m.Groups.Count == 5 && !string.IsNullOrEmpty(m.Groups[4].Value))
						{
							a = string.Format("({0}) {1}-{2} ext {3}", m.Groups[1].Value, m.Groups[2].Value, m.Groups[3].Value, m.Groups[4].Value);
						}
						else if (m.Groups.Count == 4 || (m.Groups.Count == 5 && string.IsNullOrEmpty(m.Groups[4].Value)))
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
