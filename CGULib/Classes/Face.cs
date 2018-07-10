using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGULib.Classes
{
    public class Face<T> where T : VectorBase
    {
        HalfEdge<T> outterEdge;
        HalfEdge<T>[] holes;

        //TODO: Region properties
    }
}
