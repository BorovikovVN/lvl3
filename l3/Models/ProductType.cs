using System;
using System.Collections.Generic;

namespace l3.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public int IdProductTypes { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
