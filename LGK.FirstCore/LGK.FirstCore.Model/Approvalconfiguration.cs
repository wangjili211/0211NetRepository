using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LGK.FirstCore.Model
{
    [Table("Approvalconfiguration")]
    /// <summary>
    /// 审批配置表
    /// </summary>
    public class Approvalconfiguration
    {
        [Key]
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 目标id
        /// </summary>
        public int ObjectiveId { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public int IsEnable { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 下一步节点id
        /// </summary>
        public int NextId { get; set; }

        /// <summary>
        /// 状态id
        /// </summary>
        public int Stateid { get; set; }

        /// <summary>
        /// 公司部门角色id
        /// </summary>
        public int RoleId { get; set; }
    }
}
