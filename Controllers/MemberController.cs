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
    public class MemberController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public MemberController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetMember()
        {
            IEnumerable<Member> list = this._db.Members.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetMemberByID")]
        public IActionResult GetMemberByID(int id)
        {
            var obj = this._db.Members.Find(id);
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpGet("customerID", Name = "GetMemberByCustomerID")]
        public IActionResult GetMemberByCustomerID(int CustomerID)
        {
            var obj = this._db.Members.Where(p => p.CustomerID == CustomerID).ToList();
            if (obj.Count == 0)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpPost]
         public IActionResult Create(Member obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.Members.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetMemberByID", new{id = obj.MemberID, obj});
         }

        [HttpPut("Id")]
         public IActionResult Edit(int id, Member obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            Member cus = this._db.Members.AsNoTracking().FirstOrDefault(c => c.MemberID == id);//loi khi bi entities theo doi
            this._db.Members.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetMemberByID", new{id = obj.MemberID, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            Member obj = this._db.Members.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.Members.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetMemberByID", new{id = obj.MemberID, obj});
         }
    }
}