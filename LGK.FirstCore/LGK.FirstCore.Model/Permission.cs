using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 权限表
    /// </summary>
    [Table("Permission")]
    public class Permission
    {
        [Key]
        public int Id { get; set; }     //权限id

        public string PowerName{ get; set; }   //权限名称

        public string PermissionUrl { get; set; } //Url

        public int PermissionPid { get; set; } //父级id

        public int Sort { get; set; }          //排序id

        public bool IsEnable { get; set; }    //是否启用

        public DateTime CreateTime { get; set; } //创建时间
    } 
}
