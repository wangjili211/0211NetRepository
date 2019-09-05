using System;
using System.Collections.Generic;
using System.Text;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 指标类型类别表
    /// </summary>
  public  class Indextypecategorytable
    {
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Pid { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsQi  { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}
