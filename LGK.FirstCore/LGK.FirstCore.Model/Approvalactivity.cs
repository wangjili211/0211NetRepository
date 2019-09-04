using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 审批活动表
    /// </summary>
    [Table("Approvalactivity")]
    public class Approvalactivity
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
        /// 下一步节点id
        /// </summary>
        public int NextId { get; set; }

        /// <summary>
        /// 状态id
        /// </summary>
        public int StateId { get; set; }

        /// <summary>
        /// 公司部门角色id
        /// </summary>
        public int DepartmentRoleId { get; set; }

        /// <summary>
        /// 配置表id
        /// </summary>
        public int ApproveConfigurati { get; set; }

        /// <summary>
        /// 审批意见
        /// </summary>
        public string ApprovalOpinion { get; set; }

        /// <summary>
        /// 执行操作
        /// </summary>
        public int PerformActions { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public int IsEnable { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
