using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Cart
    {
        [Key]
        public int cart_id { get; set; }

        public int? cart_quantity { get; set; }

        [ForeignKey("Customer")]
        public int cus_id { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Product")]
        public int prod_id { get; set; }
        public Product Product { get; set; }
    }
}