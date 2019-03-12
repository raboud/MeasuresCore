using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class EmailTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
