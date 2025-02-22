﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Clinic_Web_Api.Models
{
    public partial class Position
    {
        public Position()
        {
            staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public long? Salary { get; set; }
        public long? Allowance { get; set; }

        public virtual ICollection<Staff> staff { get; set; }
    }
}
