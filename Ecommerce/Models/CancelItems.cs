using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class CancelItems
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
        public string From { get; set; }
        public string To { get; set; }

    }
}
