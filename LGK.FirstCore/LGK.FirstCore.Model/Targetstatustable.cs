using System;
using System.Collections.Generic;
using System.Text;

namespace LGK.FirstCore.Model
{
  public  class Targetstatustable
    {
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Explain { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsQi { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Creationtime { get; set; }
    }
}
