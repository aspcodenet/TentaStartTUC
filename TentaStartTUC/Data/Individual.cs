using System;
using System.Collections.Generic;

#nullable disable

namespace TentaStartTUC.Data
{
    public partial class Individual
    {
        public DateTime? BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustId { get; set; }

        public virtual Customer Cust { get; set; }
    }
}
