using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}