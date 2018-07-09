using System;
using System.Collections.Generic;
using System.Text;

namespace CompGeomLib.Vertex
{

    public sealed class Vertex2 : VertexBase
    {
        public override double X { get => values[0]; set => values[0] = value; }
        public override double Y { get => values[1]; set => values[1] = value; }

        public Vertex2(double x = 0.0d, double y = 0.0d) : base(new double[2] { x, y }) { }

        #region standard overrides
        public override string ToString() => string.Format("Vertex2 - <{0}, {1}>", X, Y);
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
            if (!(vertex is Vertex2))
                throw new Exception("Vertex2 - EuclidianDistance(): vertices are not dimensionally equivalent");

            return Math.Sqrt(Math.Pow(vertex.X - X, 2) + Math.Pow(vertex.Y - Y, 2));
        }

        /// <summary>
        /// Used to calculate Manhattan distance between two Vertices.
        /// Uses reflection to ensure vertices are of same dimension.
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns> (double) Manhattan distance between two vertices </returns>
        public override double ManhattanDistance(VertexBase vertex)
        {
            if (!(vertex is Vertex2))
                throw new Exception("Vertex2 - ManhattanDistance(): vertices are not dimensionally equivalent");

            return Math.Abs(vertex.X - X) + Math.Abs(vertex.Y - Y);
        }
        #endregion
    }
    
}
