using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreEg.OrgModel
{
    public partial class Student1
    {
        public int Stid { get; set; }
        public string Stname { get; set; }
        public int? Engmark { get; set; }
        public int? Mathsmark { get; set; }
        public int? Scimark { get; set; }
        public int? Avg { get; set; }
    }
}
