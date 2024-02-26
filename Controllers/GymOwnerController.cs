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
    public class GymOwnerController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public GymOwnerController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetGymOwner()
        {
            IEnumerable<GymOwner> list = this._db.GymOwners.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetGymOwnerByID")]
        public IActionResult GetGymOwnerByID(int id)
        {
            var obj = this._db.GymOwners.Find(id);
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpPost]
         public IActionResult Create(GymOwner obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.GymOwners.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetGymOwnerByID", new{id = obj.AdminID, obj});
         }
         [HttpPost("checklogin")]
         public IActionResult CheckLogin(string username, string password)
         {
         var obj = this._db.GymOwners.AsNoTracking().FirstOrDefault(c => c.Username.Equals(username) && c.Password.Equals(password));
            if (obj == null)
            {
               return NotFound();
            }
            return Ok(obj);
         }
        [HttpPut("Id")]
         public IActionResult Edit(int id, GymOwner obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            GymOwner cus = this._db.GymOwners.AsNoTracking().FirstOrDefault(c => c.AdminID == id);//loi khi bi entities theo doi
            this._db.GymOwners.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetGymOwnerByID", new{id = obj.AdminID, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            GymOwner obj = this._db.GymOwners.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.GymOwners.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetGymOwnerByID", new{id = obj.AdminID, obj});
         }
    }
}