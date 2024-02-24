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
        public int PostID { get; set; }

        public DateTime? Date { get; set; }

        public string Content { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [ForeignKey("PersonalTrainer")]
        public int PTID { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }

        [ForeignKey("Staff")]
        public int StaffID { get; set; }
        public Staff Staff { get; set; }
    }
}