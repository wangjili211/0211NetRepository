using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using LGK.FirstCore.IRepository;
using LGK.FirstCore.Model;

namespace LGK.FirstCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private readonly IBusinessRepository businessRepository;
        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public BusinessController(IBusinessRepository _businessRepository)
        {
            businessRepository = _businessRepository;
        }

      
    }
}