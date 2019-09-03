using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }               //用户id

        public string UserName { get; set; }   //用户名称
        
        public string Pwd { get; set; }         //密码

        public string UserRealName { get; set; } //真实姓名

        public string UserRoleName { get; set; } //角色名称

        public bool IsEnable { get; set; } //是否启用

        public DateTime UserCreateTime { get; set; }  //创建时间

    }
}
