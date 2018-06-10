using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class ContactTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
    
        public List<DepartmentsContactTitle> DepartmentsContactTitles { get; set; }
    }
}
