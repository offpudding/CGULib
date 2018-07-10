using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGULib.Classes
{

    public abstract class VectorBase
    {
        protected double[] values;

        public double[] Values { get => values; }
        public int Length { get => values.Length; }

        //TODO: Vector properties

        public VectorBase(double[] values)
        {
            this.values = values;
        }
    }
    

}
