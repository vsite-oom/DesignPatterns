namespace DesignPatterns.Command
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }

    // TODO: 032a Create MoveShapeCommand class that implements ICommand
    class MoveShapeCommand : ICommand
    {
        private readonly IShape shape;
        private readonly int dx;
        private readonly int dy;
        public MoveShapeCommand(IShape shape,int dx,int dy)
        {
            this.shape = shape;
            this.dx = dx;   
            this.dy = dy;
        }
        public void Execute()
        {
            shape.Move(dx,dy);
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

            // TODO: 032b Uncomment statements below and run the program.
            MoveShapeCommand cmd = new MoveShapeCommand(sel, 3, 7);
            Console.WriteLine("Execute move shape command");
            cmd.Execute();

            Console.WriteLine("Undo move shape command");
            cmd.Undo();

        }
    }
}
