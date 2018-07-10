using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGULib.Classes
{
    public class HalfEdge<T> where T : VectorBase
    {
        HalfEdge<T> twin, prev, next;
        T origin;
        Face<T> incidentFace;

        public HalfEdge<T> Twin { get => twin; set => twin = value; }
        public HalfEdge<T> Previous { get => prev; set => prev = value; }
        public HalfEdge<T> Next { get => next; set => next = value; }
        public Face<T> IncidentFace { get => incidentFace; set => incidentFace = value; }
        public T Origin { get => origin; set => origin = value; }

    }
}
