using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using LGK.FirstCore.Model;
using LGK.FirstCore.Repository;
using LGK.FirstCore.IRepository;

namespace LGK.FirstCore.Web.Controllers
{
    public class BusinessController : Controller
    {

        private readonly IBusinessRepository BusinessRepository;
        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public BusinessController(IBusinessRepository _businessRepository)
        {
            BusinessRepository = _businessRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}