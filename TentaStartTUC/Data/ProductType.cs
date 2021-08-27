using System;
using System.Collections.Generic;

#nullable disable

namespace TentaStartTUC.Data
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public string ProductTypeCd { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
