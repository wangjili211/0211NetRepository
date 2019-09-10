using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LGK.FirstCore.Model
{
    [Table("Business")]
    /// <summary>
    /// 业务表
    /// </summary>
    
    public class Business : BaseEntity
    {
        [Key]
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 频次id
        /// </summary>
        public int FrequencyId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 级别Id
        /// </summary>
        public int LeveLId { get; set; }

        /// <summary>
        /// 责任人
        /// </summary>
        public int DutyUserId { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 当前进度
        /// </summary>
        public int NowPlan { get; set; }

        /// <summary>
        /// 状态id
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// 事项分类id
        /// </summary>
        public int MatterClassifyId { get; set; }

        /// <summary>
        /// 事项类型id
        /// </summary>
        public int MatterTypeId { get; set; }

        /// <summary>
        /// 责任单位id
        /// </summary>
        public int DutyUnitId { get; set; }

        /// <summary>
        /// 协办人id
        /// </summary>
        public int OrganiserId { get; set; }

        /// <summary>
        /// 协办人名称
        /// </summary>
        public string OrganiserName { get; set; }

        /// <summary>
        /// 填报人id
        /// </summary>
        public int FLexiblePeopleId { get; set; }
    }
}
