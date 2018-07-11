using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGULib.Classes
{
    public sealed class Vector3 : VectorBase
    {
        public double X { get => values[0]; }
        public double Y { get => values[1]; }
        public double Z { get => values[2]; }

        public Vector3(double x = 0.0d, double y = 0.0d, double z = 0.0d) : base(new double[3] { x, y, z }) { }
    }
}
