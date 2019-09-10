using System;
using System.Collections.Generic;
using System.Text;

namespace LGK.FirstCore.Model
{
    public class PageModel<T>
    {
        public List<T> Data { get; set; }

        public int RountCount { get; set; }
    }
}
