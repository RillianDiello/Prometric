using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Polymorph
{
    internal class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3) : base(DefineTypeTriangle(side1, side2, side3))
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        //public Triangle(double x, double y) : base
        public Triangle(double x) : base("Equilateral")
        {
            Side1 = Side2 = Side3 = x;
        }

        public static double CalcBase(double side1, double side2, double side3)
        {
            if (side1 > side2 && side1 > side3)
            {
                return side1;
            }
            else if (side2 > side1 && side2 > side3)
            {
                return side2;
            }
            else
            {
                return side3;
            }
        }
        public static double CalcHeight(double side1, double side2, double side3)
        {
            double sp = (side1 + side2 + side3) / 2;
            double hf = Math.Sqrt(
                sp * (sp - side1) * (sp - side2) * (sp - side3)
            );
            return ((2 * hf) / CalcBase(side1, side2, side3));
        }

        public static string DefineTypeTriangle(double side1, double side2, double side3)
        {
            if (side1 == side2 && side1 == side3)
            {
                return "Equilatero";
            }
            else if (side1 != side2 && side2 != side3 && side1 != side3)
            {
                return "Scalene";
            }
            else
            {
                return "Isosceles";
            }
        }

        public override void CalcPerimeter()
        {
            SetPerimeter(Side1 + Side2 + Side3);
        }

        public override void CalcSurface()
        {
            SetSurface(Math.Sqrt(
                 Perimeter * (Perimeter - Side1) * (Perimeter - Side2) * (Perimeter - Side3)
             ));
        }

        public override string ToString()
        {
            return "Shape: " + Name + " Side1: " + Side1 + " Side2: " + Side2 + " Side3: " + Side3
               + "\nPerimeter: " + Perimeter + " Surface: " + Surface;
        }
    }
}
