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
    public class PaymentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public PaymentController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetPayment()
        {
            IEnumerable<Payment> list = this._db.Payments.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetPaymentByID")]
        public IActionResult GetPaymentByID(int id)
        {
            var obj = this._db.Payments.Find(id);
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpPost]
         public IActionResult Create(Payment obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.Payments.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPaymentByID", new{id = obj.pay_id, obj});
         }

        [HttpPut("Id")]
         public IActionResult Edit(int id, Payment obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            Payment cus = this._db.Payments.AsNoTracking().FirstOrDefault(c => c.pay_id == id);//loi khi bi entities theo doi
            this._db.Payments.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPaymentByID", new{id = obj.pay_id, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            Payment obj = this._db.Payments.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.Payments.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPaymentByID", new{id = obj.pay_id, obj});
         }
         [HttpGet("GetCusIdPayment", Name = "GetPaymentByCustomerID")]
      public IActionResult GetPaymentByCustomerID(int customerID)
      {
         try
         {
            // Tìm các payment dựa trên CustomerID
            var payments = _db.Payments.Where(o => o.cus_id == customerID).ToList();

            // Kiểm tra xem có payment nào không
            if (payments == null || !payments.Any())
            {
               // Trả về NotFound nếu không tìm thấy payment
               return NotFound("No payments found for the given customer ID.");
            }

            // Trả về danh sách các payment
            return Ok(payments);
         }
         catch (Exception ex)
         {
            // Trả về StatusCode 500 nếu có lỗi xảy ra
            return StatusCode(500, $"Internal server error: {ex.Message}");
         }
      }
    }
}