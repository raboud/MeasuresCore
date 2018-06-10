using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class EmailType
    {
        public int Id { get; set; }
        public string Description { get; set; }
    
        public List<EmailTemplate> EmailTemplates { get; set; }
    }
}
