using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
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
                shape.Accept(visitor);
        }

        private List<Shape> shapes = new List<Shape>();
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

        private TextWriter writer;

        public void Visit(Circle circle)
        {
            writer.WriteLine($"Circle: x0={circle.xCenter}, y0={circle.yCenter}, r={circle.radius}");
        }

        public void Visit(Rectangle rectangle)
        {
            writer.WriteLine($"Rectangle: x0={rectangle.xLeft}, y0={rectangle.yLeft}, w={rectangle.height}, h={rectangle.height}");
        }
    }

    class ShapeMoveVisitor : IShapeVisitor
    {
        public ShapeMoveVisitor(double dx,double dy)
        {
            this.dx = dx;
            this.dy = dy;
        }
        private readonly double dx;
        private readonly double dy;
        public void Visit(Circle circle)
        {
            circle.xCenter += dx;
            circle.yCenter += dy;
        }

        public void Visit(Rectangle rectangle)
        {
            rectangle.xLeft += dx;
            rectangle.yLeft += dy;

        }
    }

    class AreaCalculatorVisitor : IShapeVisitor
    {
        public AreaCalculatorVisitor()
        {
            Area = 0;
        }
        public void Visit(Circle circle)
        {
            double area = circle.radius * circle.radius * Math.PI;
            Area += area;
        }

        public void Visit(Rectangle rectangle)
        {
            double area = rectangle.height * rectangle.width;
            Area += area;
        }

        public double Area { get; private set; }
    }

    class Program
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

            AreaCalculatorVisitor visitor2 = new AreaCalculatorVisitor();
            drawing.AcceptVisitor(visitor2);
            Console.WriteLine(visitor2.Area);


        }
    }
}
