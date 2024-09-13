using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Notification
    {
        [Key]
        public int noti_id { get; set; }

        public DateTime? noti_date { get; set; }

        public string noti_context { get; set; }

        [StringLength(50)]
        public string noti_type { get; set; }

        [ForeignKey("Customer")]
        public int cus_id { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("PersonalTrainer")]
        public int pt_id { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }
    }
}