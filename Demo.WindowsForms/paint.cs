using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.WindowsForms
{
    class Point
    {
        public double x;
        public double y;

        public Point()
        {
        }

        public Point(double a, double b)
        {
            x = a;
            y = b;
        }

        public static void Write(Point A)
        {
            Console.Write("Write(Point A): ");
            Console.Write(A.x + " ");
            Console.WriteLine(A.y);
        }

        public static Point Coordinate(Point A, double a, double b)
        {
            A.x = a;
            A.y = b;
            Point.Write(A);
            return A;
        }
    }

    class Line : Point
    {
        public Point A;
        public Point B;

        public Line()
        {
        }

        public Line(Point A1, Point B1)
        {
            this.A = A1;
            this.B = B1;
        }

        public static void Write(Line C)
        {
            if ((C.A.x == null) || (C.B.x == null) || (C.A.y == null) || (C.B.y == null))
            {
                return;
            }
            else
            {
                Console.Write("Write(Line C): ");
                Console.Write(C.A.x + " ");
                Console.Write(C.A.y + " ");
                Console.Write(C.B.x + " ");
                Console.WriteLine(C.B.y + " ");
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double x = 1;
    //        double y = 1;
    //        Point A = new Point(x, y);
    //        Point B = new Point(x + 5, y + 7);
    //        Point.Write(A);
    //        Point.Write(B);

    //        Point p = new Point();
    //        p = Point.Coordinate(4, 10);

    //        Line E = new Line(A, B);
    //        Line.Write(E);
    //    }
    //}
}
