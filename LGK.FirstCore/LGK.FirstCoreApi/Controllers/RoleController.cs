﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LGK.FirstCore.IRepository;
using LGK.FirstCore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LGK.FirstCoreApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
   
    public class RoleController : ControllerBase
    {

        private readonly IRoleRepository roleRepository;
        /// <summary>
        ///构造函数注入
        /// </summary>
        /// <param name="_roleRepository"></param>
        public RoleController(IRoleRepository _roleRepository)
        {
            roleRepository = _roleRepository;
        }

       

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteUser(int id)
        {
            var i = roleRepository.Delete(id);
            return i;
        }

        /// <summary>
        /// /显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Role> GetAll()
        {
            var list = roleRepository.GetRole();
            return list;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(Role role)
        {
            int i = roleRepository.Insert(role);
            return i;
        }
    }
}