using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class PermissionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    
        public List<Permission> Permissions { get; set; }
    }
}
