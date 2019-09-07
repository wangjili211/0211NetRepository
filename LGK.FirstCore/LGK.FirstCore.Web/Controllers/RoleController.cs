using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LGK.FirstCore.Model;
using LGK.FirstCore.Repository;
using LGK.FirstCore.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LGK.FirstCore.Web.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleRepository roleRepository;
        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public RoleController(IRoleRepository _roleRepository)
        {
            roleRepository = _roleRepository;
        }

        [HttpPost]
        public int AddRole(Role entity)
        {
            var i = roleRepository.Insert(entity);
            return i;
        } 

        public ActionResult AddRole()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public Role UpdateUser(int Id)
        {
            Role i = roleRepository.GetModelById(Id);
            return i;

        }
        public ActionResult UpdateUser()
        {
            return View();
        }

    }
}