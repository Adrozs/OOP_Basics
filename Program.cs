//Adrian Rozsahegyi NET23

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Takes user input
            Console.Write("Choose a radius size for the first circle: ");
            int radius1 = int.Parse(Console.ReadLine());

            Console.Write("Choose a radius size for the second circle: ");
            int radius2 = int.Parse(Console.ReadLine());

            Console.Write("Choose a side size for a triangle: ");
            int triangleSide = int.Parse(Console.ReadLine());

            Console.Write("Choose a height size for a triangle: ");
            int triangleHeight = int.Parse(Console.ReadLine());

            Console.Write("Choose a length size for a triangle: ");
            int triangleLength = int.Parse(Console.ReadLine());

            // Calaculates area, volume and circumference of a circle with the chosen radius rounded to 2 decimals
            Circle Circle1 = new Circle(radius1);
            Console.WriteLine($"\nCircle with {radius1} as radius.");
            Console.WriteLine("Area: " + Math.Round(Circle1.GetArea(),2));
            Console.WriteLine("Volume: " + Math.Round(Circle1.GetVolume(), 2));
            Console.WriteLine("Circumference: " + Math.Round(Circle1.GetCircumference(), 2));

            // Calaculates area, volume and circumference of another circle with the chosen radius rounded to 2 decimals
            Circle Circle2 = new Circle(radius2);
            Console.WriteLine($"\nCircle with {radius2} as radius.");
            Console.WriteLine("Area: " + Math.Round(Circle2.GetArea(),2));
            Console.WriteLine("Volume: " + Math.Round(Circle2.GetVolume(), 2));
            Console.WriteLine("Circumference: " + Math.Round(Circle2.GetCircumference(), 2));

            // Calculates area, hypothenuse and volume of a Triangle with the chosen height and side
            Triangle triangle1 = new Triangle(triangleSide, triangleHeight, triangleLength);
            Console.WriteLine($"\nTriangle with side {triangleSide}, height {triangleHeight} and length {triangleLength}");
            Console.WriteLine("Area: " + triangle1.GetArea());
            Console.WriteLine("Hypothenuse: " + Math.Round(triangle1.GetHypotenuse()));
            Console.WriteLine("Volume: " + Math.Round(triangle1.GetVolume()));
        }
    }

    public class Circle
    {
        // declaring radius variable
        private double _radius;

        // Constructor takes the input and assings it to the declared variable to be able to use it in the method below
        public Circle(double radius)
        { 
            _radius = radius;
        }

        // GetArea calculates the area of a circle from the values we've gotten previously (radius) and returns them
        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }

        // GetVolume calculates the volume of a circle from the values we've gotten previously (radius) and returns them
        public double GetVolume() 
        { 
            return (4 * Math.PI * Math.Pow(_radius, 3)) / 3;
        }

        // GetCircumference calculates the circumference of a circle from the values we've gotten previously
        // (radius) and returns them
        public double GetCircumference()
        {
            return (2 * Math.PI) * _radius;
        }
    }

    public class Triangle
    {
        // Declares varables for later use
        private double _side;
        private double _height;
        private double _length;

        // Constructor takes the input and assings it to the declared variable to be able to use it in the method below
        public Triangle(double side, double height, double length)
        {
            _side = side;
            _height = height;
            _length = length;
        }

        // returns the area of the triangle
        public double GetArea() 
        {
            return (_side * _height) / 2;
        }

        // returns the hypotenuse of the triangle
        public double GetHypotenuse()
        {
            return Math.Sqrt((_side * _side) + (_height * _height));
        }

        // returns the volume of the triangle
        public double GetVolume()
        {
            return (GetArea() * _length);
        }

    }

}