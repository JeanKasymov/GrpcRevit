﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcWpf.Models
{
    public class Data<T>
    {
        public List<T> Items { get; set; }
    }
}
