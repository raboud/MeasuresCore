using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class EmailImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }
    }
}
