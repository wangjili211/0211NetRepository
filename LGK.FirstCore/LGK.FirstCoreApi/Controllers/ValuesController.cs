using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LGK.FirstCore.IRepository;
using LGK.FirstCore.Model;
using Microsoft.AspNetCore.Mvc;

namespace LGK.FirstCoreApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet("Get")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [HttpGet("{id}")]
        // GET api/values/5
        public ActionResult<string> Get(int id)
        {
            return "value";
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
        }


       /// <summary>
       /// 删除
       /// </summary>
       /// <param name="id"></param>
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
    
