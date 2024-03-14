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
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public OrderController(ApplicationDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public IActionResult GetOrder()
        {
            IEnumerable<Order> list = this._db.Orders.OrderByDescending(n => n.OrderID).ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetOrderByID")]
        public IActionResult GetOrderByID(int id)
        {
            var obj = this._db.Orders.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
        [HttpPost]
        public IActionResult Create(Order obj)
        {
            if (obj == null)
            {
                return BadRequest("...");
            }
            this._db.Orders.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetOrderByID", new { id = obj.OrderID, obj });
        }

        [HttpPut("Id")]
        public IActionResult Edit(int id, Order obj)
        {
            if (obj == null)
            {
                return BadRequest("...");
            }
            Order cus = this._db.Orders.AsNoTracking().FirstOrDefault(c => c.OrderID == id);//loi khi bi entities theo doi
            this._db.Orders.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPTByID", new { id = obj.OrderID, obj });
        }
        [HttpDelete("Id")]
        public IActionResult Delete(int id)
        {
            Order obj = this._db.Orders.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            this._db.Orders.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPTByID", new { id = obj.OrderID, obj });
        }

        [HttpGet("CustomerID", Name = "CopyDataFromCartToOrder")]
        public async Task<IActionResult> CopyDataFromCartToOrder(int customerID)
        {
            try
            {
                // Tìm các mục trong giỏ hàng dựa trên CustomerID
                var products = _db.Products.ToList();
                var cartItems = await _db.Carts
                                        .Where(c => c.CustomerID == customerID)
                                        .ToListAsync();

                if (cartItems == null || cartItems.Count == 0)
                {
                    return NotFound("No cart items found for the given customer ID.");
                }
                List<int> listOrderID = new List<int>();
                foreach (var cartItem in cartItems)
                {
                    var productForPrice = products.FirstOrDefault(c => c.ProductID == cartItem.ProductID);
                    var orderItem = new Order
                    {
                        CustomerID = cartItem.CustomerID,
                        ProductID = cartItem.ProductID,
                        Status = "Waiting", // Thiết lập trạng thái mới cho đơn hàng
                        StartDate = DateTime.Now, // Thiết lập ngày bắt đầu cho đơn hàng
                        Total = (int)productForPrice.Price * (int)cartItem.Quantity, // Khởi tạo tổng tiền
                        Quantity = cartItem.Quantity ?? 0 // Lấy số lượng từ giỏ hàng
                    };
                    _db.Orders.Add(orderItem);
                    _db.Carts.Remove(cartItem);
                    await _db.SaveChangesAsync();
                    listOrderID.Add(_db.Orders.Max(o => o.OrderID));
                }
                return Ok(listOrderID);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetCusId", Name = "GetOrderByCustomerID")]
        public IActionResult GetOrderByCustomerID(int customerID)
        {
            try
            {
                // Tìm các đơn hàng dựa trên CustomerID
                var orders = _db.Orders.Where(o => o.CustomerID == customerID).OrderByDescending(n => n.OrderID).ToList();

                // Kiểm tra xem có đơn hàng nào không
                if (orders == null || !orders.Any())
                {
                    // Trả về NotFound nếu không tìm thấy đơn hàng
                    return NotFound();
                }

                // Trả về danh sách các đơn hàng
                return Ok(orders);
            }
            catch (Exception ex)
            {
                // Trả về StatusCode 500 nếu có lỗi xảy ra
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        
    }
}