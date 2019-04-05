using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class Permission
    {
        public Permission()
        {
            this.SubPermissions = new List<Permission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PermissionTypeId { get; set; }
        public int ParentId { get; set; }

        public List<Permission> SubPermissions { get; set; }

        public PermissionType PermissionType { get; set; }
        public List<UserPermission> UserPermissions { get; set; }
    }
}
