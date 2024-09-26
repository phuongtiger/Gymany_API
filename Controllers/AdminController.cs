using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Gymany_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Gymany_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public AdminController(ApplicationDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public IActionResult GetAdmin()
        {
            IEnumerable<Admin> list = this._db.Admins.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetAdminByID")]
        public IActionResult GetAdminByID(int id)
        {
            var obj = this._db.Admins.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
        [HttpPost]
        public IActionResult Create(Admin obj)
        {
            if (obj == null)
            {
                return BadRequest("...");
            }
            this._db.Admins.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetAdminByID", new { id = obj.admin_id, obj });
        }

        [HttpPut("Id")]
        public IActionResult Edit(int id, Admin obj)
        {
            if (obj == null)
            {
                return BadRequest("...");
            }
            Admin cus = this._db.Admins.AsNoTracking().FirstOrDefault(c => c.admin_id == id);//loi khi bi entities theo doi
            this._db.Admins.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPTByID", new { id = obj.admin_id, obj });
        }
        [HttpDelete("Id")]
        public IActionResult Delete(int id)
        {
            Admin obj = this._db.Admins.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            this._db.Admins.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPTByID", new { id = obj.admin_id, obj });
        }
        [HttpPost("checklogin")]
        public IActionResult CheckLogin(string username, string password)
        {
            var obj = this._db.Admins.AsNoTracking().FirstOrDefault(c => c.admin_username.Equals(username) && c.admin_password.Equals(password));
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
    }
}