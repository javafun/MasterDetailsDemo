using System.Collections.Generic;

namespace MasterDetailsDemo.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
    }
}