using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGULib.Classes;

namespace CGULib.Voronoi
{
    public static class Voronoi
    {
        public static DCEL<T> VoronoiSubdivideRegion<T>(DCEL<T> region, List<T> points, bool isEuclidian = true) where T : VectorBase
        {
            return new DCEL<T>("voronoi", "this is a voronoi subdivision");
        }
    }
}
