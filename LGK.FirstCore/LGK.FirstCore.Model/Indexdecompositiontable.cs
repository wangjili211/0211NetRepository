using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LGK.FirstCore.Model
{
    /// <summary>
    /// 指标分解表
    /// </summary>
    [Table("Indexdecompositiontable")]
   public class Indexdecompositiontable
    {
        [Key]
        public int      Id               { get; set; }//id
        public int      Targettableid    { get; set; }  //目标月id
        public int      Jan              { get; set; }  //1月
        public int      Jan_Feb        { get; set; }    //1-2月
        public int      Jan_Mar        { get; set; }    //1-3月
        public int      Jan_Apr        { get; set; }    //1-4月
        public int      Jan_May        { get; set; }    //1-5月
        public int      Jan_Jun        { get; set; }    //1-6月
        public int      Jan_Jul        { get; set; }    //1-7月
        public int      Jan_Aug        { get; set; }    //1-8月
        public int      Jan_Sep        { get; set; }    //1-9月
        public int      Jan_Oct        { get; set; }    //1-10月
        public int      Jan_Nov        { get; set; }    //1-11月
        public int      Annualobjectives { get; set; }  //年度目标
        public DateTime Creationtime { get; set; }      //创建时间

    }
}
