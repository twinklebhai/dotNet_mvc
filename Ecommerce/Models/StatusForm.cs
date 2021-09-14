using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class StatusForm
    {
        [Key]
        public int Orders { get; set; }
        public int OrderId { get; set; }
    }
}
