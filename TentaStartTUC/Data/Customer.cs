using System;
using System.Collections.Generic;

#nullable disable

namespace TentaStartTUC.Data
{
    public partial class Customer
    {
        public Customer()
        {
            Accounts = new HashSet<Account>();
            Officers = new HashSet<Officer>();
        }

        public int CustId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CustTypeCd { get; set; }
        public string FedId { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }

        public virtual Business Business { get; set; }
        public virtual Individual Individual { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Officer> Officers { get; set; }
    }
}
