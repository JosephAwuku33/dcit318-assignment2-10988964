using System;

namespace AbstractClass
{
    // Abstract class Shape
    public abstract class Shape
    {
        // Abstract method GetArea
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        private double radius;

        // Constructor for Circle
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implement GetArea method
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        // Constructor
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Implement GetArea method
        public override double GetArea()
        {
            return length * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Shape myCircle = new Circle(9.0);
            Shape myRectangle = new Rectangle(5.0, 8.0);

            // Display their areas
            Console.WriteLine($"The area of the circle is: {myCircle.GetArea()}");
            Console.WriteLine($"The area of the rectangle is: {myRectangle.GetArea()}");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
