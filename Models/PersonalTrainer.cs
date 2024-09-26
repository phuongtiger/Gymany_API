using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class PersonalTrainer
    {
        [Key]
        public int pt_id { get; set; }

        [Required]
        [StringLength(50)]
        public string pt_username { get; set; }

        [Required]
        [StringLength(50)]
        public string pt_password { get; set; }

        [StringLength(50)]
        public string pt_name { get; set; }

        public DateTime? pt_age { get; set; }

        [StringLength(50)]
        public string pt_address { get; set; }

        public decimal? pt_salary { get; set; }

        [Required]
        [StringLength(50)]
        public string pt_email { get; set; }

        [StringLength(20)]
        public string pt_phone { get; set; }

        [StringLength(200)]
        public string pt_img { get; set; }
    }
}