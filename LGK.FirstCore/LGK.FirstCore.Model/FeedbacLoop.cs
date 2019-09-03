using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 反馈周期表
    /// </summary>
    [Table("FeedbacLoop")]
    public class FeedbacLoop
    {
        [Key]
        public  int          Id            { get; set; }//id
        public  DateTime     Time        { get; set; }//时间
        public  string  RemindContent { get; set; }//提醒内容
        public  DateTime     UpdateTime    { get; set; }//修改时间
        public DateTime CreateTime { get; set; }//创建时间

    }
}
