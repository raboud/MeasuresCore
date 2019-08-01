using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    
    public partial class CustomerType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public byte[] Logo { get; set; }
        public string QBClass { get; set; }
    
        //public List<ClientTypeReport> ClientTypeReports { get; set; }
        //public List<Program> Programs { get; set; }
        public List<Client> Clients { get; set; }
    }
}
