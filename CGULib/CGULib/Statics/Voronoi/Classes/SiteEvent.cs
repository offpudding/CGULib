using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGULib.Containers;
using CGULib.Classes;

namespace CGULib.Statics.Voronoi.Classes
{
    class SiteEvent : PriorityQueue
    {
        public SiteEvent(VectorBase key) : base(key) { }
    }
}
