using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Polymorph
{
    internal class Circle : Shape
    {
        protected double Radius { get; }
        public Circle(double x) : base("circle")
        { 
            Radius = x;
        }

        public override void CalcPerimeter()
        {
            SetPerimeter(Radius *  Constants.Pi);
        }

        public override void CalcSurface()
        {
            SetSurface(Math.Pow(Radius, 2) * Constants.Pi );
        }

        public override string ToString()
        {
            return "Shape: " + Name + " Radius: " + Radius
                + "\nPerimeter: " + Perimeter + " Surface: " + Surface;
        }
    }
}
