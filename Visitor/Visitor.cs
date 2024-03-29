﻿namespace DesignPatterns.Visitor
{
    abstract class Shape
    {
        public abstract void Accept(IShapeVisitor visitor);
    }

    class Circle : Shape
    {
        public Circle(double xCenter, double yCenter, double radius)
        {
            this.xCenter = xCenter;
            this.yCenter = yCenter;
            this.radius = radius;
        }

        public double xCenter;
        public double yCenter;
        public double radius;

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(double xLeft, double yLeft, double width, double height)
        {
            this.xLeft = xLeft;
            this.yLeft = yLeft;
            this.width = width;
            this.height = height;
        }

        public double xLeft;
        public double yLeft;
        public double width;
        public double height;

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    class Drawing
    {
        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void AcceptVisitor(IShapeVisitor visitor)
        {
            foreach (Shape shape in shapes)
            { 
                shape.Accept(visitor);
            }
        }

        private readonly List<Shape> shapes = new List<Shape>();
    }

    interface IShapeVisitor
    {
        void Visit(Circle circle);
        void Visit(Rectangle rectangle);
    }

    class SaveShapeVisitor : IShapeVisitor
    {
        public SaveShapeVisitor(TextWriter writer)
        {
            this.writer = writer;
        }

        private readonly TextWriter writer;

        public void Visit(Circle circle)
        {
            writer.WriteLine($"Circle: x0={circle.xCenter}, y0={circle.yCenter}, r={circle.radius}");
        }

        public void Visit(Rectangle rectangle)
        {
            writer.WriteLine($"Rectangle: x0={rectangle.xLeft}, y0={rectangle.yLeft}, w={rectangle.height}, h={rectangle.height}");
        }
    }

    // TODO: 3.5 Add and implement MoveShapeVisitor class and test it.

    static internal class Program
    {
        static void Main(string[] args)
        {
            Drawing drawing = new Drawing();
            drawing.AddShape(new Circle(5, 10, 5));
            drawing.AddShape(new Rectangle(20, 30, 5, 8));

            StringWriter sw = new StringWriter();
            SaveShapeVisitor visitor = new SaveShapeVisitor(sw);
            drawing.AcceptVisitor(visitor);

            Console.WriteLine(sw.ToString());

        }
    }
}
