using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreEg.OrgModel
{
    public partial class StudentAddress
    {
        public StudentAddress()
        {
            Students = new HashSet<Student>();
        }

        public int StudentAddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
