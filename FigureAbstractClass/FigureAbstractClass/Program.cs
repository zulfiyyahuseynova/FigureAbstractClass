using System;

namespace FigureAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("0 - Quit");
            Square s1 = new Square(5);
            Rectangle r1 = new Rectangle(4, 8);
            int key = 0;
            do
            {
                Console.WriteLine("Enter the number");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("------------------------");
                        Console.WriteLine(s1.CalcArea());
                        Console.WriteLine("------------------------");
                        break;
                    case 2:
                        Console.WriteLine("------------------------");
                        Console.WriteLine(r1.CalcArea());
                        Console.WriteLine("------------------------");
                        break;
                    case 0:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("The program ended");
                        Console.WriteLine("------------------------");
                        break;
                    default:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("There is no such method");
                        Console.WriteLine("------------------------");
                        break;
                } 
            }
            while (key != 0);
        }
    }
    abstract class Figure
    {
        public abstract double CalcArea();
    }
    class Square : Figure
    {
        public double side;
        public Square(double side)
        {
            this.side = side;
        }

        public override double CalcArea()
        {
            return side * side;
        }
    }
    class Rectangle : Figure
    {
        public double width;
        public double length;
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public override double CalcArea()
        {
            return width * length;
        }
    }
}
