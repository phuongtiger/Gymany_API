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
    public class NotificationController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public NotificationController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetNotification()
        {
            IEnumerable<Notification> list = this._db.Notifications.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetNotiByCustomerID")]
        public IActionResult GetNotiByCustomerID(int id)
        {
            var obj = this._db.Notifications.Where(n => n.CustomerID == id).OrderByDescending(n => n.NotificationID).ToList();
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpPost]
         public IActionResult Create(Notification obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.Notifications.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetNotificationByID", new{id = obj.NotificationID, obj});
         }

        [HttpPut("Id")]
         public IActionResult Edit(int id, Notification obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            Notification cus = this._db.Notifications.AsNoTracking().FirstOrDefault(c => c.NotificationID == id);//loi khi bi entities theo doi
            this._db.Notifications.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetNotificationByID", new{id = obj.NotificationID, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            Notification obj = this._db.Notifications.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.Notifications.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetNotificationByID", new{id = obj.NotificationID, obj});
         }
    }
}