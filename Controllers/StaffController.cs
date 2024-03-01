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
    public class StaffController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public StaffController(ApplicationDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public IActionResult GetStaff()
        {
            IEnumerable<Staff> list = this._db.Staffs.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetStaffByID")]
        public IActionResult GetStaffByID(int id)
        {
            var obj = this._db.Staffs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
        [HttpPost]
        public IActionResult Create(Staff obj)
        {
            if (obj == null)
            {
                return BadRequest("...");
            }
            this._db.Staffs.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetStaffByID", new { id = obj.StaffID, obj });
        }

        [HttpPut("Id")]
        public IActionResult Edit(int id, Staff obj)
        {
            if (obj == null)
            {
                return BadRequest("...");
            }
            Staff cus = this._db.Staffs.AsNoTracking().FirstOrDefault(c => c.StaffID == id);//loi khi bi entities theo doi
            this._db.Staffs.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPTByID", new { id = obj.StaffID, obj });
        }
        [HttpDelete("Id")]
        public IActionResult Delete(int id)
        {
            Staff obj = this._db.Staffs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            this._db.Staffs.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPTByID", new { id = obj.StaffID, obj });
        }
        [HttpPost("checklogin")]
        public IActionResult CheckLogin(string username, string password)
        {
            var obj = this._db.Staffs.AsNoTracking().FirstOrDefault(c => c.Username.Equals(username) && c.Password.Equals(password));
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
    }
}