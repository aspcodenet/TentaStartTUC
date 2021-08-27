using System;
using System.Collections.Generic;

#nullable disable

namespace TentaStartTUC.Data
{
    public partial class AccTransaction
    {
        public decimal TxnId { get; set; }
        public double Amount { get; set; }
        public DateTime FundsAvailDate { get; set; }
        public DateTime TxnDate { get; set; }
        public string TxnTypeCd { get; set; }
        public int? AccountId { get; set; }
        public int? ExecutionBranchId { get; set; }
        public int? TellerEmpId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Branch ExecutionBranch { get; set; }
        public virtual Employee TellerEmp { get; set; }
    }
}
