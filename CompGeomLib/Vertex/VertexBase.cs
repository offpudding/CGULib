using System;

namespace CompGeomLib.Vertex
{
    public abstract class VertexBase
    {
        protected double[] values;
        public virtual double X { get { throw new Exception("Vertex does not contain x component"); } set { throw new Exception("Vertex does not contain x component"); } }
        public virtual double Y { get { throw new Exception("Vertex does not contain y component"); } set { throw new Exception("Vertex does not contain y component"); } }
        public virtual double Z { get { throw new Exception("Vertex does not contain z component"); } set { throw new Exception("Vertex does not contain z component"); } }
        public virtual double W { get { throw new Exception("Vertex does not contain w component"); } set { throw new Exception("Vertex does not contain w component"); } }

        public VertexBase(double[] values)
        {
            this.values = values;
        }

        #region Standard overrides
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region Implementation Functions
        /// <summary>
        /// Used to calculate euclidian distance between two vertices.
        /// Uses reflection to ensure vertices are of same dimension.
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns> (double) Euclidian distance between two Vertices </returns>
        public abstract double EuclidianDistance(VertexBase vertex);

        /// <summary>
        /// Used to calculate Manhattan distance between two Vertices.
        /// Uses reflection to ensure vertices are of same dimension.
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns> (double) Manhattan distance between two vertices </returns>
        public abstract double ManhattanDistance(VertexBase vertex);
        #endregion

        #region Static Functions
        /// <summary>
        /// Static version of EuclidianDistance() that does not rely on reflection.
        /// To be used when dimensional equivalence is guaranteed or higher dimensions can be ignored.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns> Euclidian distance between lowest dimensions </returns>
        public static double EuclidianDistance(VertexBase v1, VertexBase v2)
        {
            double val = 0.0d;

            for(int i = 0; i < Math.Min(v1.values.Length, v2.values.Length); i++)
            {
                val += Math.Pow(v2.values[i] - v1.values[i], 2);
            }

            return Math.Sqrt(val);
        }

        /// <summary>
        /// static version of ManhattanDistance() that does not rely on reflection.
        /// To be used when dimensional equivalence is guaranteed or higher dimensions can be ignored.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns> Manhattan distance between lowest dimensions </returns>
        public static double ManhattanDistance(VertexBase v1, VertexBase v2)
        {
            double val = 0.0d;

            for (int i = 0; i < Math.Min(v1.values.Length, v2.values.Length); i++)
            {
                val += Math.Abs(v2.values[i] - v1.values[i]);
            }

            return val;
        }
        #endregion
    }
}
