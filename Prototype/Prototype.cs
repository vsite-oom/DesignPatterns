namespace DesignPatterns.Prototype
{
    class Program
    {
        static void Main()
        {
            var triangle1 = new Polygon(new Point(1, 3), new Point(5, 7), new Point(1, 9));

            Console.WriteLine("triangle1 vertices:");
            Console.WriteLine(string.Join(", ", triangle1.Points));
            Console.WriteLine();

            // TODO: 014 Implement ICloenable interface for Polygon class and uncomment statement below.
            var triangle2 = triangle1.Clone();
            //var triangle2 = triangle1;
            triangle1.Move(3, -5);

            Console.WriteLine("triangle2 vertices:");
            Console.WriteLine(string.Join(", ", triangle2.Points));
            Console.WriteLine();

            Console.WriteLine("triangle1 vertices:");
            Console.WriteLine(string.Join(", ", triangle1.Points));
            Console.WriteLine();
        }
    }
}
