﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class rectangle : IShape
    {
        double a;
        double b;
        public rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double area()
        {
            return a * b;
        }

    }
}
