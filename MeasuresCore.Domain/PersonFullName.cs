using System;
using System.Collections.Generic;
using System.Text;

namespace RandREng.MeasuresCore.Domain
{
    public class PersonFullName
    {
		public PersonFullName(string givenName, string surName)
		{

		}

		public string SurName { get; set; }
		public string GivenName { get; set; }
		public string FullName => $"{GivenName} {SurName}";
		public string FullNameReverse => $"{SurName}, {GivenName}";
	}
}
