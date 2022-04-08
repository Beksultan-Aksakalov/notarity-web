﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Territory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Address Address { get; set; }
        public Employee Employee { get; set; }
    }
}
