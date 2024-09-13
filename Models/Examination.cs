using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Examination
    {
        [Key]
        public int exam_id { get; set; }

        [StringLength(50)]
        public string exam_title { get; set; }

        [StringLength(50)]
        public string exam_question { get; set; }

        [ForeignKey("Course")]
        public int course_id { get; set; }
        public Course Course { get; set; }

        [ForeignKey("PersonalTrainer")]
        public int pt_id { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }
    }
}