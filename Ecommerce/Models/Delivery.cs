using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Delivery
    {
        [Key]
        public int ItemId { get; set; }
        public string From { get; set; }
         public string To { get; set; }
        [ForeignKey("ItemId")]
        public OrderItem OrderItem { get; set; }

    }
}
