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
        [HttpGet("ptid", Name = "GetPostByPTID")]
         public IActionResult GetPostByPTID(int ptid)
         {
            // Tìm tất cả các bài viết với ptid là khóa chính
            var posts = this._db.Posts.Where(p => p.PTID == ptid).OrderByDescending(n => n.PostID).ToList();

            // Kiểm tra xem có bài viết nào không
            if (posts == null || posts.Count == 0)
            {
               return NotFound();
            }

            // Trả về danh sách bài viết
            return Ok(posts);
         }
        [HttpGet]
        public IActionResult GetPost()
        {
            IEnumerable<Post> list = this._db.Posts.OrderByDescending(n => n.PostID).ToList();
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
         [HttpGet("PostID", Name = "GetBlogDetailByPostID")]
         public IActionResult GetBlogDetailByPostID(int PostID)
         {
            // Tìm tất cả các bài viết với ptid là khóa chính
            var posts = this._db.Posts.Where(p => p.PostID == PostID).ToList();

            // Kiểm tra xem có bài viết nào không
            if (posts == null || posts.Count == 0)
            {
               return Ok(posts);
            }

            // Trả về danh sách bài viết
            return Ok(posts);
         }
    }
}