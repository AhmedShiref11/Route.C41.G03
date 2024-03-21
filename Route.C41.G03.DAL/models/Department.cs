﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.C41.G03.DAL.models
{
    public class Department
    {
        public int Id { get; set; } 
        public string Code { get; set; }

        public string Name { get; set; }

        public DateTime DateOfCreation { get; set; }
    }
}
