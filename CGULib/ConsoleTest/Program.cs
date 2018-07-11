using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGULib.Classes;
using CGULib.Containers;
using CGULib.Statics.Voronoi;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Test root;
            root = new Test(10);

            for (int i = 5; i >= 0; i--)
                root = root.Insert(root, new Test(i)) as Test;

            while (root != null)
            {
                Test temp = root.Min(root) as Test;
                root = root.Delete(root, temp) as Test;
                Console.WriteLine(temp.Key);
            }

            Console.ReadLine();
        }
    }

    class Test : AVLNode<int>
    {
        public Test(int key) : base(key)
        {
        }

        public override int CompareTo(int other)
        {
            return key.CompareTo(other);
        }
    }
}
