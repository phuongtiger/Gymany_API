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
         [HttpPost]
      [Route("CreateCartByCustomerID")]
      public async Task<IActionResult> CreateCartByCustomerID(int customerID, int productID)
      {
         try
         {
            // Check if the customer and product exist
            var customer = await _db.Customers.FindAsync(customerID);
            var product = await _db.Products.FindAsync(productID);

            if (customer == null || product == null)
            {
               return NotFound(); // Return 404 Not Found if customer or product is not found
            }

            // Check if the product already exists in the customer's cart
            var existingCart = await _db.Carts.FirstOrDefaultAsync(c => c.CustomerID == customerID && c.ProductID == productID);

            if (existingCart != null)
            {
               // If the product exists, increase the quantity by 1
               existingCart.Quantity++;
            }
            else
            {
               // If the product doesn't exist, create a new cart item
               var newCart = new Cart
               {
                  CustomerID = customerID,
                  ProductID = productID,
                  Quantity = 1 // Initial quantity is 1
               };
               _db.Carts.Add(newCart);
            }

            await _db.SaveChangesAsync();

            return Ok(); // Return 200 OK if the operation is successful
         }
         catch (Exception ex)
         {
            // Log the error for troubleshooting
            Console.WriteLine($"Error: {ex.Message}");
            return StatusCode(500, $"Internal server error: {ex.Message}"); // Return 500 Internal Server Error for unexpected errors
         }
      }

      // [HttpPost]
      // [Route("CreateCartByCustomerID")]
      // public async Task<IActionResult> CreateCartByCustomerID(int customerID, int productID, int quantity)
      // {
      //    try
      //    {
      //       // Check if the customer and product exist
      //       var customer = await _db.Customers.FindAsync(customerID);
      //       var product = await _db.Products.FindAsync(productID);

      //       if (customer == null || product == null)
      //       {
      //          return NotFound(); // Return 404 Not Found if customer or product is not found
      //       }

      //       // Check if the product already exists in the customer's cart
      //       var existingCart = await _db.Carts.FirstOrDefaultAsync(c => c.CustomerID == customerID && c.ProductID == productID);

      //       if (existingCart != null)
      //       {
      //          // If the product exists, increase the quantity
      //          existingCart.Quantity += quantity;
      //       }
      //       else
      //       {
      //          // If the product doesn't exist, create a new cart item
      //          var newCart = new Cart
      //          {
      //             CustomerID = customerID,
      //             ProductID = productID,
      //             Quantity = quantity 
      //          };
      //          _db.Carts.Add(newCart);
      //       }

      //       await _db.SaveChangesAsync();

      //       return Ok(); // Return 200 OK if the operation is successful
      //    }
      //    catch (Exception ex)
      //    {
      //       // Log the error for troubleshooting
      //       Console.WriteLine($"Error: {ex.Message}");
      //       return StatusCode(500, $"Internal server error: {ex.Message}"); // Return 500 Internal Server Error for unexpected errors
      //    }
      // }



       // POST: api/CartApi/UpdateCartItem
        [HttpPost("UpdateCartItem")]
        public async Task<IActionResult> UpdateCartItem(int cartId, int quantity)
        {
            var cartItem = await _db.Carts.FindAsync(cartId);
            if (cartItem == null)
            {
                return NotFound();
            }

            cartItem.Quantity = quantity;

            try
            {
                await _db.SaveChangesAsync();
                return Ok(); // Return success if update is successful
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest("Failed to update cart item.");
            }
        }
    }
}