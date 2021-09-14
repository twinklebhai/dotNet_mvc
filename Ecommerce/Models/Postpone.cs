using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Postpone
    {
        [Key]
        public int PostponeId { get; set; }
        public string From { get; set; }
        public string To { get; set; }

    }
}
