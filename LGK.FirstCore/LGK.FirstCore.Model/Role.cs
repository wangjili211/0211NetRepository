using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LGK.FirstCore.Model
{
    public class Role: BaseEntity
    {
        [Key]
        public int RoleId { get; set; }

        public string RoleName { get; set; }
    }
}
