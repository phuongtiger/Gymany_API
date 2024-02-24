using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymany_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gymany_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public PostController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetPost()
        {
            IEnumerable<Post> list = this._db.Posts.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetPostByID")]
        public IActionResult GetPostByID(int id)
        {
            var obj = this._db.Posts.Find(id);
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpPost]
         public IActionResult Create(Post obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.Posts.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPostByID", new{id = obj.PostID, obj});
         }

        [HttpPut("Id")]
         public IActionResult Edit(int id, Post obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            Post cus = this._db.Posts.AsNoTracking().FirstOrDefault(c => c.PostID == id);//loi khi bi entities theo doi
            this._db.Posts.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPostByID", new{id = obj.PostID, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            Post obj = this._db.Posts.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.Posts.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPostByID", new{id = obj.PostID, obj});
         }
    }
}