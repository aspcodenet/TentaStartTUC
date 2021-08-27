using System;
using System.Collections.Generic;

#nullable disable

namespace TentaStartTUC.Data
{
    public partial class Account
    {
        public Account()
        {
            AccTransactions = new HashSet<AccTransaction>();
        }

        public int AccountId { get; set; }
        public double? AvailBalance { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public DateTime OpenDate { get; set; }
        public double? PendingBalance { get; set; }
        public string Status { get; set; }
        public int? CustId { get; set; }
        public int OpenBranchId { get; set; }
        public int OpenEmpId { get; set; }
        public string ProductCd { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual Branch OpenBranch { get; set; }
        public virtual Employee OpenEmp { get; set; }
        public virtual Product ProductCdNavigation { get; set; }
        public virtual ICollection<AccTransaction> AccTransactions { get; set; }
    }
}
