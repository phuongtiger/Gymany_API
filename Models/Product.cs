using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? Amount { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        public decimal? Price { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}