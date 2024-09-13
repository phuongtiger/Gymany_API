using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class WorkoutPlan
    {
        [Key]
        public int workout_id { get; set; }

        [StringLength(50)]
        public string workout_name { get; set; }

        public DateTime? workout_startDate { get; set; }

        public DateTime? workout_endDate { get; set; }

        public string workout_description { get; set; }

        public string workout_session { get; set; }

        public string workout_activity { get; set; }


        [ForeignKey("PersonalTrainer")]
        public int pt_id { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }

         [ForeignKey("Exercise")]
        public int exc_id { get; set; }
        public Exercise Exercise { get; set; }
    }
}