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
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetCategories()
        {
            IEnumerable<Category> list = this._db.Categories.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetCategories")]
        public IActionResult GetCategories(int id)
        {
            var obj = this._db.Categories.Find(id);
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpPost]
         public IActionResult Create(Category obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.Categories.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetCategories", new{id = obj.CategoryID, obj});
         }

        [HttpPut("Id")]
         public IActionResult Edit(int id, Category obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            Category cus = this._db.Categories.AsNoTracking().FirstOrDefault(c => c.CategoryID == id);//loi khi bi entities theo doi
            this._db.Categories.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetCategories", new{id = obj.CategoryID, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            Category obj = this._db.Categories.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.Categories.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetCategories", new{id = obj.CategoryID, obj});
         }
    }
}