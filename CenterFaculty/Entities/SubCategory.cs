﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterFaculty.Entities
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
