﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Domain.Dtos
{
    public class StudentDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Class { get; set; }
    }
}
