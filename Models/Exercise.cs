using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Exercise
    {
        [Key]
        public int exc_id { get; set; }

        [Required]
        [StringLength(50)]
        public string exc_title { get; set; }

        [Required]
        [StringLength(50)]
        public string exc_description { get; set; }

        [StringLength(50)]
        public string exc_guide { get; set; }

        [StringLength(50)]
        public string exc_video { get; set; }
    }
}