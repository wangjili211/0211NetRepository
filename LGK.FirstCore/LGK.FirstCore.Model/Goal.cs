using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 目标表
    /// </summary>
    [Table("Goal")]
    public  class Goal

    {
        [Key]
        public int          Id               { get; set; }   //id
        public string   Name             { get; set; } //名称
        public int          Targetstateid    { get; set; } //目标状态ID
        public int          Theunitid        { get; set; }//指标单位id
        public int          Pointertypeid    { get; set; }//指标类型id
        public int          Categoriesid     { get; set; }//指标类别id
        public int          Indexlevelid     { get; set; }//指标等级id
        public int          Frequencyid      { get; set; }//反馈频次id
        public DateTime     GoalStartTime    { get; set; }//开始时间
        public DateTime GoalEndTime      { get; set; }//完成时间
        public int          GoalPeriod       { get; set; }//周期
        public int          GoalUnit         { get; set; }//责任单位
        public string  GoalChargePeople { get; set; }//责任人
        public int          GoalWeight       { get; set; }//考核权重
        public string  GoalInformant    { get; set; }//填报人
        public string  GoalOrganiser    { get; set; }//协办人名称
        public string GoalFormula      { get; set; }//计算公式
        public string GoalSources      { get; set; }//数据来源
        public int          FileId           { get; set; }//文件ID
        public DateTime CreateTime { get; set; }//创建时间

  
        public int Business_State { get; set; }// 待办状态 待办已办

      
        public int FeedbackId { get; set; }// 进度百分比

     
        public int Goal_DutyUserId { get; set; }// 责任人

    
        public int Goal_DutyCommanyId { get; set; }// 责任单位

        public int Goal_ParentId { get; set; }// 父级节点

    }
}
