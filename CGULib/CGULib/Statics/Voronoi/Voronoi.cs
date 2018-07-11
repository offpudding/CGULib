using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGULib.Classes;
using CGULib.Containers;
using CGULib.Statics.Voronoi.Classes;

namespace CGULib.Statics.Voronoi
{
    public static class Voronoi
    {
        public static DCEL<T> VoronoiSubdivideRegion<T>(DCEL<T> region, List<T> points, bool isEuclidian = true) where T : VectorBase
        {
            PriorityQueue root;
            root = new PriorityQueue(points[points.Count - 1]);
            points.RemoveAt(points.Count - 1);

            foreach(VectorBase v in points)
            {
                SiteEvent e = new SiteEvent(v);
                root = root.Insert(root, e) as PriorityQueue;
            }

            while(root != null)
            {
                PriorityQueue temp = root.Min(root) as PriorityQueue;
                root = root.Delete(root, temp) as PriorityQueue;
                Console.WriteLine("Vec: {0},{1}", temp.Key.Values[0], temp.Key.Values[1]);
            }

            return new DCEL<T>("voronoi", "this is a voronoi subdivision");
        }
    }
}
