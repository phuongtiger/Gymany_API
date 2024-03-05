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
    public class WorkoutPlanController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public WorkoutPlanController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetWorkoutPlan()
        {
            IEnumerable<WorkoutPlan> list = this._db.WorkoutPlans.ToList();
            return Ok(list);
        }
        [HttpGet("id", Name = "GetWorkoutPlanByID")]
        public IActionResult GetWorkoutPlanByID(int id)
        {
            var obj = this._db.WorkoutPlans.Find(id);
            if (obj==null)
            {
               return NotFound(); 
            }
            return Ok(obj);
        }
         [HttpGet("ptid", Name = "GetWorkoutByPTID")]
         public IActionResult GetWorkoutByPTID(int ptid)
         {
            // Tìm tất cả các bài viết với ptid là khóa chính
            var workoutPlans = this._db.WorkoutPlans.Where(p => p.PTID == ptid).ToList();

            // Kiểm tra xem có bài viết nào không
            if (workoutPlans == null || workoutPlans.Count == 0)
            {
               return NotFound();
            }

            // Trả về danh sách bài viết
            return Ok(workoutPlans);
         }
         [HttpGet("MemberID", Name = "GetWorkoutByMemID")]
         public IActionResult GetWorkoutByMemID(int memberid)
         {
            // Tìm tất cả các bài viết với ptid là khóa chính
            var workoutPlans = this._db.WorkoutPlans.Where(p => p.MemberID == memberid).ToList();

            // Kiểm tra xem có bài viết nào không
            if (workoutPlans == null || workoutPlans.Count == 0)
            {
               return NotFound();
            }

            // Trả về danh sách bài viết
            return Ok(workoutPlans);
         }
        [HttpPost]
         public IActionResult Create(WorkoutPlan obj)
         {
            if (obj == null)
            {
               return BadRequest("..."); 
            }
            this._db.WorkoutPlans.Add(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetWorkoutPlanByID", new{id = obj.WorkoutPlanID, obj});
         }

        [HttpPut("Id")]
         public IActionResult Edit(int id, WorkoutPlan obj)
         {
            if (obj==null)
            {
               return BadRequest("..."); 
            }
            WorkoutPlan cus = this._db.WorkoutPlans.AsNoTracking().FirstOrDefault(c => c.WorkoutPlanID == id);//loi khi bi entities theo doi
            this._db.WorkoutPlans.Update(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetWorkoutPlanByID", new{id = obj.WorkoutPlanID, obj});
         }
         [HttpDelete("Id")]
         public IActionResult Delete(int id)
         {
            WorkoutPlan obj = this._db.WorkoutPlans.Find(id);
            if (obj == null)
            {
               return NotFound(); 
            }
            this._db.WorkoutPlans.Remove(obj);
            this._db.SaveChanges();
            return CreatedAtRoute("GetWorkoutPlanByID", new{id = obj.WorkoutPlanID, obj});
         }
    }
}