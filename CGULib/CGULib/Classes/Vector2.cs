using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGULib.Classes
{
    public sealed class Vector2 : VectorBase
    {
        public double X { get => values[0]; }
        public double Y { get => values[1]; }

        public Vector2(double x = 0.0d, double y = 0.0d) : base(new double[2] { x, y }) { }
    }
}
