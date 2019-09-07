
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LGK.FirstCore.IRepository;
using LGK.FirstCore.Model;
using LGK.FirstCore.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LGK.FirstCoreApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        /// <summary>
        /// 定义私有变量
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

        // GET api/values/5
        [HttpPost]
        public int AddUser(Userss entity)
        {
            Userss mModel = new Userss();
            Role rModel = new Role();

            userRepository.Insert(entity);
            return 1;
        }


    }
}