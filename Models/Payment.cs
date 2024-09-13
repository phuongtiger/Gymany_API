using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Payment
    {
        [Key]
        public int pay_id { get; set; }

        public DateTime? pay_date { get; set; }

        public int? pay_quantity { get; set; }

        [ForeignKey("Customer")]
        public int cus_id { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Product")]
        public int prod_id { get; set; }
        public Product Product { get; set; }
    }
}