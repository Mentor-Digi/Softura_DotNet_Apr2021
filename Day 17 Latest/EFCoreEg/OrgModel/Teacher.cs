using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreEg.OrgModel
{
    public partial class Teacher
    {
        public Teacher()
        {
            Students = new HashSet<Student>();
        }

        public int TeacherId { get; set; }
        public string TeacherName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
