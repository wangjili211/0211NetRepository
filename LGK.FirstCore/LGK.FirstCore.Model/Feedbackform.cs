using System;
using System.Collections.Generic;
using System.Text;

namespace LGK.FirstCore.Model
{
  public  class Feedbackform
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 目标id
        /// </summary>
        public int Targetid { get; set; }
        /// <summary>
        /// 状态表
        /// </summary>
        public int Statetableid { get; set; }
        /// <summary>
        /// 累计工作进展
        /// </summary>
        public string Cumulativeworkprogress { get; set; }
        /// <summary>
        /// 当日周进展
        /// </summary>
        public string NaDailyprogressme { get; set; }
        /// <summary>
        /// 存在问题
        /// </summary>
        public string Existingproblem { get; set; }
        /// <summary>
        /// 解决措施
        /// </summary>
        public string Countermeasure { get; set; }
        /// <summary>
        /// 需集团协调事项
        /// </summary>
        public string Groupcoordination  { get; set; }

        /// <summary>
        /// 当前进展
        /// </summary>
        public int currentprogress { get; set; }

    }
}
