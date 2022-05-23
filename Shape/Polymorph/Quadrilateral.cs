using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Polymorph
{
    public class Quadrilateral : Shape
    {
        protected double Width { get; }
        protected double Height { get; }
        public Quadrilateral(double w, double h) : base(IsSquare(w,h))
        {
            Width = w;
            Height = h;
        }

        public Quadrilateral(double x) : base("square")
        {
            Width = x;
            Height = x;
        }

        public Quadrilateral(Quadrilateral ob) : base(ob) { }

        public static string IsSquare(double w,double h)
        {
            if (w == h)
                return "Square";
            return "Rectangle";
        }

        public override void CalcPerimeter()
        {
            this.SetPerimeter(2 * Width + 2 * Height);
        }

        public override void CalcSurface()
        {
            this.SetSurface(Width * Height);
        }

        public override string ToString()
        {
            return "Shape: " + Name + " Width: " + Width + " Height: " + Height
               + "\nPerimeter: " + Perimeter + " Surface: " + Surface;
        }
    }
}
