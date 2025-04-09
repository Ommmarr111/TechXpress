using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechXpress.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }
        public string ImageUrl { get; set; }
        public bool IsAvailable { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
