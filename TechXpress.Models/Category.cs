﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechXpress.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
