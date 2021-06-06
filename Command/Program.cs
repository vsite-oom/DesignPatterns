using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    abstract class Shape
    {
        public abstract void Move(int dx, int dy);
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
    }

    interface ICommand
    {
        void Execute();
        void Undo();
    }

    class MoveShapeCommand : ICommand
    {
        public MoveShapeCommand(Shape shape, int dx, int dy)
        {
            this.shape = shape;
            this.dx = dx;
            this.dy = dy;
        }

        private readonly Shape shape;
        private readonly int dx;
        private readonly int dy;

        public void Execute()
        {
            shape.Move(dx, dy);
        }

        public void Undo()
        {
            shape.Move(-dx, -dy);
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

            MoveShapeCommand cmd = new MoveShapeCommand(sel, 3, 7);
            Console.WriteLine("Execute move shape command");
            cmd.Execute();

            Console.WriteLine("Undo move shape command");
            cmd.Undo();

        }
    }
}
