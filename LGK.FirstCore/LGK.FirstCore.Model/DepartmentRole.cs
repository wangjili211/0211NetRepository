using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 公司部门角色表
    /// </summary>
    [Table("DepartmentRole")]
    public class DepartmentRole
    {
        [Key]
        public int Id { get; set; }             //角色Id

        public string RoleName { get; set; }    //名称

        public int RolePid { get; set; }        //pid

        public string RoleContent { get; set; }  //角色权限内容 

        public bool IsEnable { get; set; }       //是否启用

        public DateTime RoleCreateTime { get; set; }  //创建时间

        public string RoleCreatePeople { get; set; }  //创建人

        public string RoleModifyPeople { get; set; }  //修改人

        public DateTime RoleModifyTime { get; set; }  //修改时间
    }
}
