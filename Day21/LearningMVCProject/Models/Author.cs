﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningMVCProject.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }

        public List<Book> Books { get; set; }
    }
}
