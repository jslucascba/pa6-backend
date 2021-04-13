using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.database;
using api.models;
using Microsoft.AspNetCore.Cors;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class booksController : ControllerBase
    {
        // GET: api/books
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Book> Get()
        {
            ReadBook readObj = new ReadBook();
            return readObj.GetAllBooks();
        }

        // GET: api/books/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{cwid}", Name = "Get")]
        public List<Book> Get(string cwid)
        {
            ReadBook readObj = new ReadBook();
            return readObj.GetBooksByCwid(cwid);
        }

        // POST: api/books
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/books/5
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/books/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
