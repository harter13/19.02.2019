﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class AbstractProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
    }
}
