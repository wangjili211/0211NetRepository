using System;
using System.Collections.Generic;
using System.Text;

namespace LGK.FirstCore.Model
{
  public  class FileTable
    {
        /// <summary>
        /// 文件表
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 目标id
        /// </summary>
        public int Targetid { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}
