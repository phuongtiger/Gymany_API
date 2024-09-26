using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymany_API.Models
{
    public class Order
    {
        [Key]
        public int order_id { get; set; }

        [StringLength(50)]
        public string order_status { get; set; }

        public DateTime order_startDate { get; set; } // Change Date to DateTime

        public decimal order_totalPrice { get; set; }

        public int order_quantity { get; set; }

        [ForeignKey("Customer")]
        public int cus_id { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Product")]
        public int prod_id { get; set; }
        public Product Product { get; set; }
    }
}