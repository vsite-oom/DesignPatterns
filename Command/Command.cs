namespace DesignPatterns.Command
{
    interface ICommand
    {
        
        void Execute();
        void Undo();
    }

    // TODO: 3.1a Create MoveShapeCommand class that implements ICommand.

    class MoveShapeCommand : ICommand
    {
        public MoveShapeCommand(IShape shape, int dx, int dy)
        {
            this.shape = shape;
            this.dx = dx;
            this.dy = dy;
        }

        private readonly IShape shape;
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

            // TODO: 3.1b Uncomment statements below and run the program.

            MoveShapeCommand cmd = new MoveShapeCommand(sel, 3, 7);
            Console.WriteLine("Execute move shape command");
            cmd.Execute();

            Console.WriteLine("Undo move shape command");
            cmd.Undo();

            Console.WriteLine("Execute resize shape command");
            var resizeComand= new ResizeShapeCommand(sel, 2, 4);
            resizeComand.Execute();
            
            Console.WriteLine("Undo resize shape command");
            
            resizeComand.Undo();



        }
    }
}
