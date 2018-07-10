using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGULib.Classes
{
    public class LineSegment<T> where T : VectorBase
    {
        HalfEdge<T> p1;
        HalfEdge<T> p2;
    }
}
