using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        // GET: api/Joke
        [HttpGet]
        public IEnumerable<Jokemodel> Get()
        {
            return new Jokemodel[]
            {
                new Jokemodel(){id=1,Type = "黑色幽默",Contrnt = "小菜被端走了..."}
                ,new Jokemodel(){id=2,Type = "黑色幽默",Contrnt = "小菜被端走了..."}


            };
        }

        // GET: api/Joke/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Joke
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Joke/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Joke/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
