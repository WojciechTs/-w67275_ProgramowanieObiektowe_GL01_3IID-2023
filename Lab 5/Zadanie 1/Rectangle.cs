using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Shapes
{
    public class Rectangle : Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override double CalulateArea()
        {
            return X*Y;
        }
    }
}
