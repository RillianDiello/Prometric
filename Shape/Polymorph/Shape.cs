
namespace Shapes.Polymorph
{
    public abstract class Shape
    { 

        //public double Width { get; set; }
        //public double Height { get; set; }
        protected string Name { get; set; }

        protected double Perimeter { get; private set; }
        protected double Surface { get; private set; }

        protected Shape(string name, double perimeter = 0, double surface = 0)
        {
            Name = name;
            Perimeter = perimeter;
            Surface = surface;
        }

        protected Shape(string name)
        {
            Name = name;
        }


        public Shape(Shape ob)
        {
            Perimeter = ob.Perimeter;
            Surface = ob.Surface;
            Name = ob.Name;
        }
        
        public void SetPerimeter(double p)
        {
            Perimeter = p;
        }

        public void SetSurface(double s)
        {
            Surface = s;
        }
        
        abstract public void CalcPerimeter();
        abstract public void CalcSurface();
        abstract public string ToString();

        public int CompareByPerimeter(Shape shp1, Shape shp2)
        {
            return shp1.Perimeter.CompareTo(shp2.Perimeter);
        }

        public int CompareBySurface(Shape shp1, Shape shp2)
        {
            return shp1.Surface.CompareTo(shp2.Surface);
        }

    }
}
