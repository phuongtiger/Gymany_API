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
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetCustomer()
        {
            IEnumerable<Customer> list = this._db.Customers.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetCustomerByID")]
        public IActionResult GetCustomerByID(int id)
        {
            var obj = this._db.Customers.Find(id);
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpPost]
         public IActionResult Create(Customer obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.Customers.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetCustomerByID", new{id = obj.CustomerID, obj});
         }

        [HttpPut("Id")]
         public IActionResult Edit(int id, Customer obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            Customer cus = this._db.Customers.AsNoTracking().FirstOrDefault(c => c.CustomerID == id);//loi khi bi entities theo doi
            this._db.Customers.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetCustomerByID", new{id = obj.CustomerID, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            Customer obj = this._db.Customers.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.Customers.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetCustomerByID", new{id = obj.CustomerID, obj});
         }
         [HttpPost("checklogin")]
         public IActionResult CheckLogin(string username, string password)
         {
            var obj = this._db.Customers.AsNoTracking().FirstOrDefault(c => c.Username.Equals(username) && c.Password.Equals(password));
            if (obj == null)
            {
               return NotFound();
            }
            return Ok(obj);
         }
    }
}