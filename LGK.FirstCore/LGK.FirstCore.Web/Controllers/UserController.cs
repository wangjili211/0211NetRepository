﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LGK.FirstCore.Model;
using LGK.FirstCore.Repository;
using LGK.FirstCore.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public int AddUser(Userss entity)
        {
            var i = userRepository.Insert(entity);
            return  i;
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