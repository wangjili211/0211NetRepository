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

        //public string Index1(string currentpage, string Name)
        //{
        //    var Rolelist = roleRepository.Entities.ToList();

        //    if (currentpage == null)
        //    {
        //        currentpage = "1";
        //    }
        //    if (!String.IsNullOrEmpty(Name))
        //    {
        //        Rolelist = Rolelist.Where(u => u.RoleName.Contains(Name)).ToList();
        //    }

        //    int totlepage =Rolelist.Count / 3 + (Rolelist.Count % 3 == 0 ? 0 : 1);
        //    Rolelist = Rolelist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();


        //    PageModel pagemodelfirst = new PageModel();
        //    pagemodelfirst.CurrentPage = int.Parse(currentpage);
        //    pagemodelfirst.TotlePage = totlepage;
        //    pagemodelfirst.PageData = Rolelist;

        //    var json = JsonConvert.SerializeObject(pagemodelfirst);
        //    return json;
        //}

        public int DeleteUser(Role Id)
        {            
            var i= roleRepository.Delete(Id);
            return i;
        }
    }
}