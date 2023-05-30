namespace DesignPatterns.Composite
{
    interface Shape
    {
        abstract void Move(int dx, int dy);
    }

    class Circle : Shape
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

    class Rectangle : Shape
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
}
