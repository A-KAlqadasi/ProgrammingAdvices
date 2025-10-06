using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Point
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Operator overloading for + 
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        // Operator overloading for -
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }
        // Operator overloading for *
        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.X * p2.X, p1.Y * p2.Y);
        }
        // Operator overloading for /
        public static Point operator/(Point p1, Point p2)
        {
            return new Point(p1.X / p2.X, p1.Y / p2.Y);
        }
        // Operator overloading for ==
        public static bool operator ==(Point p1, Point p2)
        {
            return (p1.X == p2.X) && (p1.Y == p2.Y);
        }
        // Operator overloading for !=

        public static bool operator !=(Point p1, Point p2)
        {
            return (p1.X == p2.X) && (p1.Y == p2.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 4);
            Point point2 = new Point(3, 5);
            Console.WriteLine($"Point1 : " + point1);
            Console.WriteLine($"Point2 : " + point2);
            Point point3 = point1 + point2;

            Console.WriteLine($"Point3 is the result of point1 + point2: {point3}");
            Point point4 = point1 - point2;

            Console.WriteLine($"Point4 is the result of point1 - point2: {point4}");

            if(point1 == point2)
            {
                Console.WriteLine($"Using == Yes, point1 equals point2");
            }
            else
                Console.WriteLine($"Using == no, point1 dosn't equals point2");
            if (point1 != point2)
            {
                Console.WriteLine($"Using != Yes, point1 dosn't equals point2");
            }
            else
                Console.WriteLine($"Using != no, point1  equals point2");


            Console.ReadKey();

        }
    }
}
