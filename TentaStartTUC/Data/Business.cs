using System;
using System.Collections.Generic;

#nullable disable

namespace TentaStartTUC.Data
{
    public partial class Business
    {
        public DateTime? IncorpDate { get; set; }
        public string Name { get; set; }
        public string StateId { get; set; }
        public int CustId { get; set; }

        public virtual Customer Cust { get; set; }
    }
}
