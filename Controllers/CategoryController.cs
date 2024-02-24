using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymany_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gymany_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db){
            this._db = db;
        } 
        [HttpGet]
        public IActionResult GetCategories()
        {
            IEnumerable<Category> list = this._db.Categories.ToList();
            return Ok(list);
        }
    }
}