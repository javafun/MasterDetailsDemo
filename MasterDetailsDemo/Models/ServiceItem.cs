using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailsDemo.Models
{
    public class ServiceItem
    {
        public int ServiceItemId { get; set; }
        public string ServiceItemCode { get; set; }
        public string ServiceItemName { get; set; }
        public decimal Rate { get; set; }

    }
}
