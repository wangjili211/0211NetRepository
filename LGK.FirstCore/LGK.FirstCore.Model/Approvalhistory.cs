using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LGK.FirstCore.Model
{
    [Table("Approvalhistory")]
    /// <summary>
    /// 审批历史表
    /// </summary>
    public class Approvalhistory
    {
        [Key]
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 活动表id
        /// </summary>
        public int ApprovalActivityId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

    }
}
