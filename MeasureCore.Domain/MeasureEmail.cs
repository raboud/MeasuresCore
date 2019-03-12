using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class MeasureEmail
    {
        public int Id { get; set; }
        public int MeasureId { get; set; }
        public System.DateTime Sent { get; set; }
        public int EmailTemplateId { get; set; }
    
        public Measure Measure { get; set; }
        public EmailTemplate EmailTemplate { get; set; }
    }
}
