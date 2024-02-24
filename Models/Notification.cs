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
        public int NotificationID { get; set; }

        public DateTime? Date { get; set; }

        public string Context { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("PersonalTrainer")]
        public int PTID { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }
    }
}