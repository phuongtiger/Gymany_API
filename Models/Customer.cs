using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Customer
    {
        [Key]
        public int cus_id { get; set; }

        [Required]
        [StringLength(50)]
        public string cus_username { get; set; }

        [Required]
        [StringLength(50)]
        public string cus_password { get; set; }

        [StringLength(50)]
        public string cus_name { get; set; }

        [StringLength(50)]
        public string cus_address { get; set; }

        public DateTime? cus_age { get; set; }

        [StringLength(200)]
        public string cus_image { get; set; }

        [StringLength(20)]
        public string cus_phone { get; set; }

        [Required]
        [StringLength(50)]
        public string cus_email { get; set; }
    }
}