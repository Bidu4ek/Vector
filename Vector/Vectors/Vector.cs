using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Vector
    {
        double xv;
        double yv;
        double zv;
        double len;

        public double Xv { get => xv; set => xv = value; }
        public double Yv { get => yv; set => yv = value; }
        public double Zv { get => zv; set => zv = value; }
        public double Len { get => len; set => len = value; }

        public Vector()
        {

        }

        public Vector(double xv, double yv, double zv)
        {
            this.xv = xv;
            this.yv = yv;
            this.zv = zv;
            len = Math.Sqrt(xv * xv + yv * yv + zv * zv);
        }
    }
}
