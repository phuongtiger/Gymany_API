using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Category
    {
         [Key]
        public int cate_id { get; set; }

        [Required]
        [StringLength(50)]
        public string cate_type { get; set; }
        [StringLength(200)]
        public string cate_img { get; set; }

        public string cate_description { get; set; }
    }
}