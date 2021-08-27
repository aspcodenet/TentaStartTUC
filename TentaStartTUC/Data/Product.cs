using System;
using System.Collections.Generic;

#nullable disable

namespace TentaStartTUC.Data
{
    public partial class Product
    {
        public Product()
        {
            Accounts = new HashSet<Account>();
        }

        public string ProductCd { get; set; }
        public DateTime? DateOffered { get; set; }
        public DateTime? DateRetired { get; set; }
        public string Name { get; set; }
        public string ProductTypeCd { get; set; }

        public virtual ProductType ProductTypeCdNavigation { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
