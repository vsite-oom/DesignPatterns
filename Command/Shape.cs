namespace DesignPatterns.Command
{
    interface IShape
    {
        public void Move(int dx, int dy);
    }

    class Circle : IShape
    {
        public Circle()
        {
            instance = ++instances;
        }

        public void Move(int dx, int dy)
        {
            Console.WriteLine($"Move circle {instance} by: {dx}, {dy}");
        }

        private readonly int instance;

        private static int instances = 0;
    }

    class Rectangle : IShape
    {
        public Rectangle()
        {
            instance = ++instances;
        }

        public void Move(int dx, int dy)
        {
            Console.WriteLine($"Move rectangle {instance} by: {dx}, {dy}");
        }

        private readonly int instance;

        private static int instances = 0;
    }

    class Selection : IShape
    {
        private readonly List<IShape> selection = new List<IShape>();

        public void AddShape(IShape shape)
        {
            selection.Add(shape);
        }

        public void RemoveShape(IShape shape)
        {
            selection.Remove(shape);
        }

        public void Move(int dx, int dy)
        {
            foreach (var shape in selection)
            {
                shape.Move(dx, dy);
            }
        }
    }
}
