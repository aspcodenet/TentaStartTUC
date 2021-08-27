using System;
using System.Collections.Generic;

#nullable disable

namespace TentaStartTUC.Data
{
    public partial class Employee
    {
        public Employee()
        {
            AccTransactions = new HashSet<AccTransaction>();
            Accounts = new HashSet<Account>();
            InverseSuperiorEmp = new HashSet<Employee>();
        }

        public int EmpId { get; set; }
        public DateTime? EndDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public string Title { get; set; }
        public int? AssignedBranchId { get; set; }
        public int? DeptId { get; set; }
        public int? SuperiorEmpId { get; set; }

        public virtual Branch AssignedBranch { get; set; }
        public virtual Department Dept { get; set; }
        public virtual Employee SuperiorEmp { get; set; }
        public virtual ICollection<AccTransaction> AccTransactions { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Employee> InverseSuperiorEmp { get; set; }
    }
}
