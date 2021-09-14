using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class PostponeForm
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public string Reason { get; set; }

        public int Rating { get; set; }

    }
}
