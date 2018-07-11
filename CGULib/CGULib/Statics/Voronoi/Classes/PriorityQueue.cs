using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGULib.Containers;
using CGULib.Classes;

namespace CGULib.Statics.Voronoi.Classes
{
    public class PriorityQueue : AVLNode<VectorBase>
    {
        public PriorityQueue(VectorBase v) : base(v) { }

        public override int CompareTo(VectorBase other)
        {
            int i = key.Length - 1;
            while (i >= 0)
            {
                if (key.Values[i] < other.Values[i])
                    return 1;
                else if (key.Values[i] > other.Values[i])
                    return -1;
                else
                    --i;
            }
            return 0;
        }
    }
}
