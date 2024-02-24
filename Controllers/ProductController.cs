using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gymany_API.Models;

namespace Gymany_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetProducts()
        {
            IEnumerable<Product> list = this._db.Products.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetProductByID")]
        public IActionResult GetProductByID(int id)
        {
            var obj = this._db.Products.Find(id);
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpPost]
         public IActionResult Create(Product obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.Products.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetProductByID", new{id = obj.ProductID, obj});
         }

        [HttpPut("Id")]
         public IActionResult Edit(int id, Product obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            Product cus = this._db.Products.AsNoTracking().FirstOrDefault(c => c.ProductID == id);//loi khi bi entities theo doi
            this._db.Products.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetProductByID", new{id = obj.ProductID, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            Product obj = this._db.Products.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.Products.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetProductByID", new{id = obj.ProductID, obj});
         }
         
         
    }
}