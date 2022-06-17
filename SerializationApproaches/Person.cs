﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationApproaches
{
    [Serializable]
    public class Person
    {
        public string? FirstName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "FirstName:" + FirstName + ", Age:" + Age;
        }
    }
}
