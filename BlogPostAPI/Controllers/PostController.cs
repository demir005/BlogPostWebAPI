using System.Collections.Generic;
using BlogPostAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostDbContext _postDbContext;

        public PostController(PostDbContext postDbContext)
        {
            _postDbContext = postDbContext;
        }

        // GET: api/Post
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Post/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Post
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
