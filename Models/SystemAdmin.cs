using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class SystemAdmin
    {
        [Key]
        public int sysad_id { get; set; }

        [Required]
        [StringLength(50)]
        public string sysad_username { get; set; }

        [Required]
        [StringLength(50)]
        public string sysad_password { get; set; }

        [StringLength(50)]
        public string sysad_name { get; set; }

        public DateTime? sysad_age { get; set; }

        [Required]
        [StringLength(50)]
        public string sysad_email { get; set; }
    }
}