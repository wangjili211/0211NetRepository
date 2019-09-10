using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LGK.FirstCore.IRepository;
using LGK.FirstCore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LGK.FirstCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
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

        // GET api/values/5
        [HttpPost]
        public int AddRole(Role entity)
        { 
            var i = roleRepository.Insert(entity);
            return i;
        }

        [HttpDelete]
        public int DeleteUser(Role Id)
        {
            Role dmodel = new Role();          
            roleRepository.Delete(Id);
            return 1;
        }
        // <summary>
        // 角色显示
        // </summary>
        // <returns></returns>
        [HttpGet]
        public List<Role> GetAll()
        {
            var list = roleRepository.GetRole();
            return list;
        }

    }
}