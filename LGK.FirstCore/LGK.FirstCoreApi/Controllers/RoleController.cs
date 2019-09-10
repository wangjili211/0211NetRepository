using System;
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
        /// 
        /// </summary>
        /// <param name="_roleRepository"></param>
        public RoleController(IRoleRepository _roleRepository)
        {
            roleRepository = _roleRepository;
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        //[HttpPost]

        //public int AddRole(Role entity)
        //{
        //    var i = roleRepository.Insert(entity);
        //    return i;
        //}

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteUser(Role Id)
        {
            var i = roleRepository.Delete(Id);
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