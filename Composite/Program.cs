using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    abstract class Shape
    {
        public abstract void Move(int dx, int dy);
        public abstract void Resize(int dx, int dy);
    }

    class Circle : Shape
    {
        public Circle()
        {
            instance = ++instances;
        }

        public override void Move(int dx, int dy)
        {
            Console.WriteLine($"Move circle {instance} by: {dx}, {dy}");
        }

        public override void Resize(int dx, int dy)
        {
            Console.WriteLine($"Resize circle {instance} by: {dx}, {dy}");
        }

        private readonly int instance;

        private static int instances = 0;
    }

    class Rectangle : Shape
    {
        public Rectangle()
        {
            instance = ++instances;
        }

        public override void Move(int dx, int dy)
        {
            Console.WriteLine($"Move rectangle {instance} by: {dx}, {dy}");
        }

        public override void Resize(int dx, int dy)
        {
            Console.WriteLine($"Resize rectangle {instance} by: {dx}, {dy}");
        }

        private readonly int instance;

        private static int instances = 0;
    }

    class Selection : Shape
    {
        private List<Shape> selection = new List<Shape>();

        public void AddShape(Shape shape)
        {
            selection.Add(shape);
        }

        public void RemoveShape(Shape shape)
        {
            selection.Remove(shape);
        }

        public override void Move(int dx, int dy)
        {
            foreach (var shape in selection)
                shape.Move(dx, dy);
        }

        public override void Resize(int dx, int dy)
        {
            foreach (var shape in selection)
                shape.Resize(dx, dy);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle();
            Rectangle r1 = new Rectangle();

            Selection sel = new Selection();
            sel.AddShape(c1);
            sel.AddShape(r1);
            sel.AddShape(c2);

            Console.WriteLine("Move first selection:");
            sel.Move(3, 4);

            Console.WriteLine("Resize first selection:");
            sel.Resize(10, 3);

            Console.WriteLine("Move second selection:");
            sel.RemoveShape(c1);
            sel.Move(1, 0);

            Console.WriteLine("Resize second selection:");
            sel.Resize(5, 6);
        }
    }
}
