﻿namespace DesignPatterns.Composite
{
    // TODO: 2.2a Create Selection class that implements Composite pattern and implements IShape interface.
    class Selection : Shape
    {
        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }
        public void RemoveShape(Shape shape)
        {
            shapes.Remove(shape);
        }

        public void Move(int dx, int dy)
        {
           foreach (var shape in shapes)
            {
                shape.Move(dx, dy);
            }
        }

        private readonly List<Shape> shapes = new List<Shape>();
    }
    

    static internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle();
            Rectangle r1 = new Rectangle();

            // TODO: 2.2b Uncomment lines below and test the functionality.

            Console.WriteLine("Move first selection:");
            var sel = new Selection();
            sel.AddShape(c1);
            sel.AddShape(r1);
            sel.AddShape(c2);

            sel.Move(3, 4);

            Console.WriteLine("Move selection with removed c1:");
            sel.RemoveShape(c1);
            sel.Move(1, 0);

            Console.WriteLine("Move another selection:");
            var anotherSel = new Selection();
            anotherSel.AddShape(sel);
            anotherSel.AddShape(c1);
            anotherSel.Move(2, -3);
        }
    }
}
