﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PjBaySite.Models
{
    public class Instatute
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Course> Courses { get; set; }
    }
}
