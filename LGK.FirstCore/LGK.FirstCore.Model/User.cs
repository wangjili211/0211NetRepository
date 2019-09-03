using System;
using System.ComponentModel.DataAnnotations;

namespace LGK.FirstCore.Model
{
    public class User: BaseEntity
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }
    }
}
