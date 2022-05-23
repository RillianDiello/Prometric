using Shapes.Polymorph;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes
{
    internal class Program
    {
        public static OptionsMenu GetChoise()
        {
            Console.WriteLine("Choose the figure for which you want to calculate the Area :");
            Console.WriteLine("\t{0} - Quadilateral", (int)OptionsMenu.Quadilateral);
            Console.WriteLine("\t{0} - Triangle", (int)OptionsMenu.Triangle);
            Console.WriteLine("\t{0} - Circle", (int)OptionsMenu.Circle);
            Console.WriteLine("\t{0} - Count Shapes", (int)OptionsMenu.CountObject);
            Console.WriteLine("\t{0} - Calc Perimeter Shapes", (int)OptionsMenu.CalcPerimeters);
            Console.WriteLine("\t{0} - Calc Surface Shapes", (int)OptionsMenu.CalcSurfaces);
            Console.WriteLine("\t{0} - List Shapes", (int)OptionsMenu.ListShapes);
            Console.WriteLine("\t{0} - Order By Perimeter", (int)OptionsMenu.OrderByPerimeter);
            Console.WriteLine("\t{0} - Order By Surface", (int)OptionsMenu.OrderBySurface);
            Console.WriteLine("\t{0} - Exit", (int)OptionsMenu.Exit);
            Console.Write("Choose : ");
            string valor = Console.ReadLine();
            OptionsMenu choise;
            if (!Enum.TryParse(valor, out choise) || !Enum.IsDefined(typeof(OptionsMenu), choise))
            {
                Console.WriteLine("Invalid option, Choose a valid option.");
                return GetChoise();
            }

            return choise;
        }
        private static double GetDouble(string prompt)
        {
            bool isValid = false;
            double value = 0;
            while (!isValid)
            {
                Console.Write(prompt);
                isValid = double.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Shapes programa");

            List<Shape> Shapes = new List<Shape>();
            OptionsMenu choise;
            while ((choise = GetChoise()) != OptionsMenu.Exit)
            {
                Shape mySahpe;
                switch (choise)
                {
                    case OptionsMenu.Quadilateral:
                        mySahpe = CreateQuadilateral();
                        Shapes.Add(mySahpe);
                        break;

                    case OptionsMenu.Triangle:
                        mySahpe = CreateTriangle();
                        Shapes.Add(mySahpe);
                        break;

                    case OptionsMenu.Circle:
                        mySahpe = CreateCircle();
                        Shapes.Add(mySahpe);
                        break;

                    case OptionsMenu.CountObject:
                        CountShapeClass(Shapes);
                        break;

                    case OptionsMenu.CalcPerimeters:
                        CalcPerimeterShapes(Shapes);
                        break;

                    case OptionsMenu.CalcSurfaces:
                        CalcSurfaceShapes(Shapes);
                        break;

                    case OptionsMenu.ListShapes:
                        ListShapes(Shapes);
                        break;
                    case OptionsMenu.OrderBySurface:
                        OrderBySurface(Shapes);
                        break;

                    case OptionsMenu.OrderByPerimeter:
                        OrderByPerimeter(Shapes);
                        break;

                    default:
                        break;
                }

            }
        }

        private static Circle CreateCircle()
        {
            double radius = GetDouble("Radius Value: ");
            return new Circle(radius);
        }
        private static Quadrilateral CreateQuadilateral()
        {
            double width = GetDouble("Width Value: ");
            double height = GetDouble("Height Value: ");
            return new Quadrilateral(width, height);
        }
        private static Triangle CreateTriangle()
        {
            double side1 = GetDouble("Side1 Value: ");
            double side2 = GetDouble("Side2 Value: ");
            double side3 = GetDouble("Side3 Value: ");
            return new Triangle(side1, side2, side3);
        }

        private static void CalcPerimeterShapes(List<Shape> listShapes)
        {
            foreach (Shape shape in listShapes)
            {
                shape.CalcPerimeter();
            }
        }

        private static void CalcSurfaceShapes(List<Shape> listShapes)
        {
            foreach (Shape shape in listShapes)
            {
                shape.CalcSurface();
            }
        }
        private static void OrderByPerimeter(List<Shape> listShapes)
        {
            listShapes.Sort((x, y) => x.CompareByPerimeter(x, y));
        }
        private static void OrderBySurface(List<Shape> listShapes)
        {
            listShapes.Sort((x, y) => x.CompareBySurface(x, y));
        }

        private static void ListShapes(List<Shape> listShapes)
        {
            foreach (Shape shape in listShapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }

        private static void CountShapeClass(List<Shape> ListShapes)
        {
            Console.WriteLine("\t Number of Objects: {0}", ListShapes.Count);

            var query = from shape in ListShapes
                    group shape by shape.GetType() into grouping
                    select new
                    {
                        Name = grouping.Key.Name,
                        NumShapes = grouping.Count()
                    };

            foreach (var shape in query)
            {
                Console.WriteLine("\t Object: {0} Quantity {1}", shape.Name, shape.NumShapes);
            }
            //ListShapes.GetType()

            //var count = ListShapes.GroupBy(x => x.GetType());
            //foreach (var el in count)
            //{   
            //    el.Count();

            //}
            //Select(new { description = g});


        }

    }
}
