using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGULib;
using CGULib.Classes;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DCEL<Vector2> dcel = new DCEL<Vector2>("test", "this is a test");

            List<VectorBase> vectors = new List<VectorBase>();
            vectors.Add(new Vector2(3.0d, 4.5d));
            dcel.AddVertex(vectors[0] as Vector2);
        }
    }
}
