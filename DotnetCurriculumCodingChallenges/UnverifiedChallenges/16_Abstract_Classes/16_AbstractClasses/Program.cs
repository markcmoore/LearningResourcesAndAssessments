using System;

namespace _16_AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Shape shape1 = new Shape();//cannot instantiate a Shape Class
            Rectangle rect1 = new Rectangle(4.5, 3.5, "rect1", 4);
            System.Console.WriteLine($"The area of rect1 is {rect1.GetArea()}.");

            Square square1 = new Square(5, 5, "square1", 4);
            System.Console.WriteLine($"The area of square1 is {square1.GetArea()}.");

            Triangle tri1 = new Triangle(6,8,10,"tri1", 3);
            System.Console.WriteLine($"The area of tri1 is {tri1.GetArea()}.");


        }
    }
}
