using System;
using System.Collections.Generic;
using System.Text;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 指标等级表
    /// </summary>
  public  class IndexGrade
    {
        public int Id             { get; set; }//Id
        public string Specifiedlevel { get; set; }//指定等级
        public DateTime Creationtime   { get; set; }//创建时间
        public bool IsQi { get; set; }//是否启用
    }
}
