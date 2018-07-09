using System;
using System.Collections.Generic;
using System.Text;

namespace CompGeomLib.Vertex
{
    public sealed class Vertex3 : VertexBase
    {
        public override double X { get => values[0]; set => values[0] = value; }
        public override double Y { get => values[1]; set => values[1] = value; }
        public override double Z { get => values[2]; set => values[2] = value; }

        public Vertex3(double x = 0.0d, double y = 0.0d, double z = 0.0d) : base(new double[3] { x, y, z }) { }

        #region Standard Overrides
        public override string ToString() => string.Format("Vertex2 - <{0}, {1}, {2}>", X, Y, Z);
        #endregion

        #region Implementation Functions
        /// <summary>
        /// Used to calculate euclidian distance between two vertices.
        /// Uses reflection to ensure vertices are of same dimension.
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns> (double) Euclidian distance between two Vertices </returns>
        public override double EuclidianDistance(VertexBase vertex)
        {
            if (!(vertex is Vertex3))
                throw new Exception("Vertex3 - EuclidianDistance(): vertices are not dimensionally equivalent.");

            return Math.Sqrt(Math.Pow(vertex.X - X, 2) + Math.Pow(vertex.Y - Y, 2) + Math.Pow(vertex.Z - Z, 2));
        }

        /// <summary>
        /// Used to calculate Manhattan distance between two Vertices.
        /// Uses reflection to ensure vertices are of same dimension.
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns> (double) Manhattan distance between two vertices </returns>
        public override double ManhattanDistance(VertexBase vertex)
        {
            if (!(vertex is Vertex3))
                throw new Exception("Vertex3 - ManhattanDistance(): vertices are not dimensionally equivalent");

            return Math.Abs(vertex.X - X) + Math.Abs(vertex.Y - Y) + Math.Abs(vertex.Z - Z);
        }
        #endregion
    }   
}
