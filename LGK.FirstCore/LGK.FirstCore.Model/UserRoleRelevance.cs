using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 用户角色关联表
    /// </summary>
    [Table("UserRoleRelevance")]
    public class UserRoleRelevance
    {
        [Key]
        public int Id { get; set; }  //用户id
        public int RoleId { get; set; } //公司部门角色id
    }
}
