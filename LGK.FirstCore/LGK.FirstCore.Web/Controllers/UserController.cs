using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LGK.FirstCore.Model;
using LGK.FirstCore.Repository;
using LGK.FirstCore.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace LGK.FirstCore.Web.Controllers
{
    public class UserController : Controller
    {
        /// </summary>
        private readonly IUserRepository userRepository;
        private readonly IRoleRepository roleRepository;
        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public UserController(IUserRepository _userRepository, IRoleRepository _roleRepository)
        {
            userRepository = _userRepository;
            roleRepository = _roleRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int AddUser(User entity)
        {
            var user = new User
            {
                UserId = 1,
                UserName = "二狗"
            };
            userRepository.Insert(entity);
            return 1;
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public int DeleteUser(int id)
        {
            userRepository.Delete(1);
            return 1;
        }
 
      
    }
}