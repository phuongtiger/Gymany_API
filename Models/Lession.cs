using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Lession
    {
        [Key]
        public int lession_id { get; set; }

        [StringLength(50)]
        public string lession_context { get; set; }

        [StringLength(50)]
        public string lesson_topic { get; set; }


        [ForeignKey("Course")]
        public int course_id { get; set; }
        public Course Course { get; set; }
    }
}