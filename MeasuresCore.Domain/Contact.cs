using System;
using System.Collections.Generic;
using System.Text;

namespace RandREng.MeasuresCore.Domain
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Primary { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string FullNameReverse => $"{LastName}, {FirstName}";

    }
}
