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
    public class SystemAdminController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public SystemAdminController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetSystemAdmin()
        {
            IEnumerable<SystemAdmin> list = this._db.SystemAdmins.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetSystemAdminByID")]
        public IActionResult GetSystemAdminByID(int id)
        {
            var obj = this._db.SystemAdmins.Find(id);
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpPost]
         public IActionResult Create(SystemAdmin obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.SystemAdmins.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetSystemAdminByID", new{id = obj.sysad_id, obj});
         }
         [HttpPost("checklogin")]
         public IActionResult CheckLogin(string username, string password)
         {
         var obj = this._db.SystemAdmins.AsNoTracking().FirstOrDefault(c => c.sysad_username.Equals(username) && c.sysad_password.Equals(password));
            if (obj == null)
            {
               return NotFound();
            }
            return Ok(obj);
         }
        [HttpPut("Id")]
         public IActionResult Edit(int id, SystemAdmin obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            SystemAdmin cus = this._db.SystemAdmins.AsNoTracking().FirstOrDefault(c => c.sysad_id == id);//loi khi bi entities theo doi
            this._db.SystemAdmins.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetSystemAdminByID", new{id = obj.sysad_id, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            SystemAdmin obj = this._db.SystemAdmins.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.SystemAdmins.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetSystemAdminByID", new{id = obj.sysad_id, obj});
         }
    }
}