using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 反馈频次表
    /// </summary>
   [Table("Feedbac_frequencytable")]
    public class Feedbac_frequencytable
    {
        [Key]
        public int Id           { get; set; }//id
        public string Name         { get; set; }//名称
        public DateTime Creationtime { get; set; }//创建时间
        public bool IsQi { get; set; }//是否启用

    }
}
