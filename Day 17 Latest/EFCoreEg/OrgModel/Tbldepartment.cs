using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreEg.OrgModel
{
    public partial class Tbldepartment
    {
        public Tbldepartment()
        {
            TblEmployees = new HashSet<TblEmployee>();
        }

        public int Deptid { get; set; }
        public string Dname { get; set; }
        public string City { get; set; }

        public virtual ICollection<TblEmployee> TblEmployees { get; set; }
    }
}
