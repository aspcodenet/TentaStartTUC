using System;
using System.Collections.Generic;

#nullable disable

namespace TentaStartTUC.Data
{
    public partial class Branch
    {
        public Branch()
        {
            AccTransactions = new HashSet<AccTransaction>();
            Accounts = new HashSet<Account>();
            Employees = new HashSet<Employee>();
        }

        public int BranchId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<AccTransaction> AccTransactions { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
