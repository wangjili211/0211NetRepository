using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LGK.FirstCore.Model
{
    [Table("Integral")]
    /// <summary>
    /// 积分表
    /// </summary>
    public class Integral
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
        /// 积分
        /// </summary>
        public int IntegraINum { get; set; }
    }
}
