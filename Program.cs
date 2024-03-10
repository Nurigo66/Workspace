
namespace Workspace
{

    abstract class Object
    {

        public double width, Height, Radius;
        public const float Pi = 3.14f;

        public abstract double Calculate();

    }
    class Rectangle : Object
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.Height = height;
        }
        public override double Calculate()
        {
            return width * Height;
        }
    }
    class Circle : Object
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double Calculate()
        {
            return Pi * Radius * Radius;
        }
    }

    class Cone : Object
    {
        public Cone(double radius, double height)
        {
            this.Radius = radius;
            this.Height = Height;
        }

        public override double Calculate()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }
    class Triangle : Object
    {

        public Triangle(double width, double height)
        {
            this.width = width;
            this.Height = height;
        }
        public override double Calculate()
        {
            return (width * Height) / 2;
        }
    }

    class Test
    {
        static void Main()
        {
            Rectangle d = new Rectangle(12, 12);
            Circle dr = new Circle(21);
            Cone k = new Cone(21, 21);
            Triangle u = new Triangle(12, 12);
            Console.WriteLine("Area of Rectangle: " + d.Calculate());
            Console.WriteLine("Area of Circle: " + dr.Calculate());
            Console.WriteLine("Area of Cone: " + k.Calculate());
            Console.WriteLine("Area of Triangle: " + u.Calculate());

            Console.Read();
        }
    }


}