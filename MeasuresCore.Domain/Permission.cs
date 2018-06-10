using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Permission
    {
        public int Id { get; set; }
        public string PermissionName { get; set; }
        public string Description { get; set; }
        public int PermissionTypeId { get; set; }
    
        public PermissionType PermissionType { get; set; }
        public List<UserPermission> UserPermissions { get; set; }
    }
}
