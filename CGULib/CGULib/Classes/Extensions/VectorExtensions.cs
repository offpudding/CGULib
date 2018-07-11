using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGULib.Classes.Extensions
{
    public static class VectorExtensions
    {
        public static double Magnitude(this VectorBase v)
        {
            double val = 0.0d;

            for (int i = 0; i < v.Length; i++)
                val += v.Values[i] * v.Values[i];

            return Math.Sqrt(val);
        }

        public static double EuclideanDistance(this VectorBase v1, VectorBase v2)
        {
            if (v1.Length != v2.Length)
                throw new Exception("VectorExtensions.EuclidianDistance() : Vectors are not dimensionally equivalent.");

            double val = 0.0d;

            for (int i = 0; i < v1.Length; i++)
                val += Math.Pow(v2.Values[i] - v1.Values[i], 2);


            return Math.Sqrt(val);
        }

        public static double ManhattanDistance(this VectorBase v1, VectorBase v2)
        {
            if (v1.Length != v2.Length)
                throw new Exception("VectorExtensions.ManhattanDistance() : Vectors are not dimensionally equivalent.");

            double val = 0.0d;

            for (int i = 0; i < v1.Length; i++)
                val += Math.Abs(v2.Values[i] - v1.Values[i]);

            return val;
        }
    }
}
