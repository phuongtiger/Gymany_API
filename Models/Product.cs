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
        public int prod_id { get; set; }

        [StringLength(50)]
        public string prod_name { get; set; }

        public string prod_description { get; set; }

        public int? prod_amount { get; set; }

        [StringLength(200)]
        public string prod_img { get; set; }

        public decimal? prod_price { get; set; }

        [ForeignKey("Category")]
        public int cate_id { get; set; }
        public Category Category { get; set; }
    }
}