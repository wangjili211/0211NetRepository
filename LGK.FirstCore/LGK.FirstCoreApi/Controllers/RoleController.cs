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
        /// <summary>
        /// 定义私有变量
        /// </summary>
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
        public int AddUser(Role entity)
        {
            Role rModel = new Role();

            roleRepository.Insert(entity);
            return 1;
        }
    }
}