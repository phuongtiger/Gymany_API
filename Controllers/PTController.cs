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
    public class PTController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public PTController(ApplicationDbContext db){
            this._db = db;
        } 
        
        [HttpGet]
        public IActionResult GetPT()
        {
            IEnumerable<PersonalTrainer> list = this._db.PersonalTrainers.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetPTByID")]
        public IActionResult GetPersonalTrainerByID(int id)
        {
            var obj = this._db.PersonalTrainers.Find(id);
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
        [HttpPost]
         public IActionResult Create(PersonalTrainer obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.PersonalTrainers.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPTByID", new{id = obj.pt_id, obj});
         }

        [HttpPut("Id")]
         public IActionResult Edit(int id, PersonalTrainer obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            PersonalTrainer cus = this._db.PersonalTrainers.AsNoTracking().FirstOrDefault(c => c.pt_id == id);//loi khi bi entities theo doi
            this._db.PersonalTrainers.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPTByID", new{id = obj.pt_id, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            PersonalTrainer obj = this._db.PersonalTrainers.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.PersonalTrainers.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetPTByID", new{id = obj.pt_id, obj});
         }
         [HttpPost("checklogin")]
         public IActionResult CheckLogin(string email, string password)
         {
            var obj = this._db.PersonalTrainers.AsNoTracking().FirstOrDefault(c => c.pt_email.Equals(email) && c.pt_password.Equals(password));
            if (obj == null)
            {
               return NotFound();
            }
            return Ok(obj);
         }
         
    }
}