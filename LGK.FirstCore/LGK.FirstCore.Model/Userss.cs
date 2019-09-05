using System;
using System.ComponentModel.DataAnnotations;

namespace LGK.FirstCore.Model
{
    public class Userss: BaseEntity
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }
    }
}
