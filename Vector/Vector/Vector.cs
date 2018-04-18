using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vector
{
    class Vector
    {
        double[] decX = new double[3];
        double[] decY = new double[3];
        double[] decZ = new double[3];
        double[] Vec = new double[3];
        double[] R = new double[3];
        double[] T = new double[3];
        public Vector()
        {

        }

        public Vector(double[] a, double[] b, double[] c)
        {
            for (int i = 0; i < 3; i++)
            {
                decX[i] = a[i];
                decY[i] = b[i];
                decZ[i] = c[i];
                Vec[i] = Math.Sqrt(a[i] * a[i] + b[i] * b[i] + c[i] * c[i]);
            }

        }
        public double Len0()
        {
            return Vec[0];

        }

        public double Len1()
        {
            return Vec[1];

        }

        public double Len2()
        {
            return Vec[2];

        }

        public double r()   //r=(a+b)xc
        {
            R[0] = decX[0] + decX[1];
            R[1] = decY[0] + decY[1];
            R[2] = decZ[0] + decZ[1];

            T[0] = R[1] * decZ[2] - R[2] * decY[2];
            T[1] = R[0] * decZ[2] - R[2] * decX[2];
            T[2] = R[0] * decY[2] - R[1] * decX[2];

            return Math.Sqrt(Math.Pow(T[0], 2) + Math.Pow(T[1], 2) + Math.Pow(T[2], 2));
        }

        public double t()   //t=(a+c)c
        {
            return (Math.Pow(((decX[0] + decX[2]) * decX[2]), 2) + Math.Pow(((decY[0] + decY[2]) * decY[2]), 2) + Math.Pow(((decZ[0] + decZ[2]) * decZ[2]), 1 / 2));
        }
    }
}

