using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailsDemo.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public int WorkOrderId { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public string InventoryCode { get; set; }
        public string InventoryName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ExtendedPrice { get; set; }
        public string Notes { get; set; }
        public bool IsInstalled { get; set; }
    }
}
