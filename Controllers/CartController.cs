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
    public class CartController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CartController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetCart()
        {
            IEnumerable<Cart> list = this._db.Carts.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetCartByID")]
        public IActionResult GetCartByID(int id)
        {
            var obj = this._db.Carts.Find(id);
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpPost]
         public IActionResult Create(Cart obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.Carts.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetCartByID", new{id = obj.CartID, obj});
         }

        [HttpPut("Id")]
         public IActionResult Edit(int id, Cart obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            Cart cus = this._db.Carts.AsNoTracking().FirstOrDefault(c => c.CartID == id);//loi khi bi entities theo doi
            this._db.Carts.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetCartByID", new{id = obj.CartID, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            Cart obj = this._db.Carts.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.Carts.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetCartByID", new{id = obj.CartID, obj});
         }
         [HttpGet("CustomerID", Name = "GetCartByCustomerID")]
         public IActionResult GetCartByCustomerID(int CustomerID)
         {
            IEnumerable<Product> listP = this._db.Products.ToList();
            IEnumerable<Customer> listCu = this._db.Customers.ToList();
            // Tìm tất cả các bài viết với ptid là khóa chính
            var carts = this._db.Carts.Where(cu => cu.CustomerID == CustomerID).ToList();

            // Kiểm tra xem có bài viết nào không
            if (carts == null || carts.Count == 0)
            {
               return Ok(carts);
            }

            // Trả về danh sách bài viết
            return Ok(carts);
         }
    }
}