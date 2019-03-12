using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class UserPermission
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MarketId { get; set; }
        public int BusinessUnitId { get; set; }
        public int PermissionId { get; set; }
    
        public BusinessUnit BusinessUnit { get; set; }
        public Employee Employee { get; set; }
        public Market Market { get; set; }
        public Permission Permission { get; set; }
    }
}
