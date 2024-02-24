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
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public string Description { get; set; }
    }
}