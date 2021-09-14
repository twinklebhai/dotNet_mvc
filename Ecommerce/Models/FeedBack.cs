using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class FeedBack
    {
        [Key]
        public int FeedBackId { get; set; }
        public int ItemId { get; set; }
        public string Operation { get; set; }
        public string Reason { get; set; }
        public int Rating { get; set; }
    }
}
