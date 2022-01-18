﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} {Value}";
        }
    }
}