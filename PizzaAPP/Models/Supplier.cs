﻿using System;
using System.Collections.Generic;

namespace PizzaAPP.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
