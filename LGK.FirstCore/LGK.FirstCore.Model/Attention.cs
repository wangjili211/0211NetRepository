using System;
using System.Collections.Generic;
using System.Text;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 关注表
    /// </summary>
  public  class Attention
    {
        public int Id { get; set; }
        /// <summary>
        /// 目标id
        /// </summary>
        public int GoalId { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool AttentionIsEnable { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime AttentionCreateTime { get; set; }
    }
}
