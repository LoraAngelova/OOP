using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class circle : IShape
    {
        double r;
        public circle(double r)
        {
            this.r = r;
        }
        public double area()
        {
            return Math.PI * r * r;
        }
    }
}
