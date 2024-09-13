using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Admin
    {
        [Key]
        public int admin_id { get; set; }

        [Required]
        [StringLength(50)]
        public string admin_username { get; set; }

        [Required]
        [StringLength(50)]
        public string admin_password { get; set; }

        [StringLength(50)]
        public string admin_name { get; set; }

        public DateTime? admin_age { get; set; }

        public decimal? admin_salary { get; set; }

        [Required]
        [StringLength(50)]
        public string admin_email { get; set; }
    }
}