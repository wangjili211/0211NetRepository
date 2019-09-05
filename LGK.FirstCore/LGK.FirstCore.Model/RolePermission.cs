using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 角色权限表
    /// </summary>
    [Table("RolePermission")]
    public class RolePermission
    {
        [Key]
        public int Id { get; set; }         //Id

        public int RoleId { get; set; }     //角色id

        public int PermissionId { get; set; } //权限id
    }
}
