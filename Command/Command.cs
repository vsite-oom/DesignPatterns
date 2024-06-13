namespace DesignPatterns.Command
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }

    // 3.1a Create MoveShapeCommand class that implements ICommand.
    class MoveShapeCommand : ICommand
    {
        public MoveShapeCommand(IShape shape, int dx, int dy)
        {
            this.shape = shape;
            this.dx = dx;
            this.dy = dy;
        }

        private readonly IShape? shape;
        private readonly int dx;
        private readonly int dy;
        public void Execute()
        {
            shape?.Move(dx, dy);
        }

        public void Undo()
        {
            shape?.Move(-dx, -dy);
        }
    }

    class ResizeShapeCommand : ICommand
    {
        public ResizeShapeCommand(IShape shape, double xFactor, double yFactor)
        {
            this.shape = shape;
            this.xFactor = xFactor;
            this.yFactor = yFactor;
        }

        private readonly IShape? shape;
        private readonly double xFactor;
        private readonly double yFactor;
        public void Execute()
        {
            shape?.Resize(xFactor, yFactor);
        }

        public void Undo()
        {
            shape?.Resize(1 / xFactor, 1 / yFactor);
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

            // 3.1b Uncomment statements below and run the program.

            MoveShapeCommand cmd = new MoveShapeCommand(sel, 3, 7);
            Console.WriteLine("Execute move shape command");
            cmd.Execute();
            Console.WriteLine();

            Console.WriteLine("Undo move shape command");
            cmd.Undo();
            Console.WriteLine();

            var resize = new ResizeShapeCommand(sel, 2, 4);
            Console.WriteLine("Execute resize shape command");
            resize.Execute();
            Console.WriteLine();

            Console.WriteLine("Undo resize shape command");
            resize.Undo();
            Console.WriteLine();

        }
    }
}