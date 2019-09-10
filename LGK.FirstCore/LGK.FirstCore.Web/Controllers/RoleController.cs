using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LGK.FirstCore.Model;
using LGK.FirstCore.Repository;
using LGK.FirstCore.IRepository;
using Microsoft.EntityFrameworkCore;
using LGK.FirstCore.Common;

namespace LGK.FirstCore.Web.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleRepository roleRepository;
        ///// <summary>
        ///// 构造函数注入
        ///// </summary>
        ///// <param name="organization"></param>
        //public RoleController(IRoleRepository _roleRepository)
        //{
        //    roleRepository = _roleRepository;
        //}

        public JsonResult Adds(Role role)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(role);
            var result = HelperHttpClient.GetAll("post", "api/role", jsonm);
            return Json(result);
        }

        public ActionResult AddRole()
        {
            return View();
        }
    
        public ActionResult Index()
        {
            return View();
        } 

       
        public Role UpdateRole(int Id)
        {
            Role i = roleRepository.GetModelById(Id);
            return i;

        }
        public ActionResult UpdateRole()
        {
            return View();
        }

        public int DeleteRole(Role RoleId)
        {
            int i = roleRepository.Delete(RoleId);
            return i;
        }
    }
}