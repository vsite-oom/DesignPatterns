using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    class Program
    {
        class Point : ICloneable
        {
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; private set; }
            public double Y { get; private set; }

            // Zadano radi formatiranog ispisa
            public override string ToString()
            {
                return $"({X}, {Y})";
            }
            public void Move(double deltaX, double deltaY)
            {
                X += deltaX;
                Y += deltaY;
            }

            public object Clone()
            {
                return MemberwiseClone();
            }
        }

        class Polygon : ICloneable
        {
            public Polygon(params Point[] points)
            {
                Points = points.ToArray();
            }

            public object Clone()
            {
                // Ovo će kreirati plitku kopiju: Points su reference koje će se samo preslikati
                return MemberwiseClone();
                //return new Polygon(Points.Select(a => (Point)a.Clone()).ToArray());
            }

            public void Move(double deltaX, double deltaY)
            {
                foreach (var point in Points)
                {
                    point.Move(deltaX, deltaY);
                }
            }

            public readonly IEnumerable<Point> Points;
        }


        static void Main(string[] args)
        {
            var triangle1 = new Polygon(new Point(1, 3), new Point(5, 7), new Point(1, 9));

            Console.WriteLine("triangle1 vertices:");
            Console.WriteLine(string.Join(", ", triangle1.Points));
            Console.WriteLine();

            var triangle2 = triangle1.Clone() as Polygon;
            triangle1.Move(3, -5);

            Console.WriteLine("triangle2 vertices:");
            Console.WriteLine(string.Join(", ", triangle2.Points));

            Console.WriteLine();
        }
    }
}
