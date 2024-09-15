using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Course
    {
        [Key]
        public int course_id { get; set; }

        [StringLength(50)]
        public string course_title { get; set; }

        [StringLength(50)]
        public string course_description { get; set; }

        [StringLength(50)]
        public string course_episode { get; set; }

        [ForeignKey("Customer")]
        public int cus_id { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("WorkoutPlan")]
        public int workout_id { get; set; }
        public WorkoutPlan WorkoutPlan { get; set; }

        [ForeignKey("PersonalTrainer")]
        public int pt_id { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }
    }
}