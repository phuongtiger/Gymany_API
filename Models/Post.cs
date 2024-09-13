using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Post
    {
        [Key]
        public int post_id { get; set; }

        public DateTime? post_date { get; set; }

        public string post_content { get; set; }

        [StringLength(100)]
        public string post_title { get; set; }

        [StringLength(200)]
        public string post_img { get; set; }

        [ForeignKey("PersonalTrainer")]
        public int pt_id { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }

        [ForeignKey("Customer")]
        public int cus_id { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Admin")]
        public int admin_id { get; set; }
        public Admin Admin { get; set; }
    }
}