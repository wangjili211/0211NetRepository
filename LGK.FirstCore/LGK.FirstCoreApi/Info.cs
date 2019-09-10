using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LGK.FirstCoreApi
{
    internal class Info : OpenApiInfo
    {
        public string Version { get; set; }
        public string Title { get; set; }
    }
}
