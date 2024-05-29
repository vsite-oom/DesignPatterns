namespace DesignPatterns.Prototype
{
    class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }

        // Zadano radi formatiranog ispisa
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        public void Move(double deltaX, double deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }
    }

    class Polygon : ICloneable
    {
        public Polygon(params Point[] points)
        {
            Points = points.ToArray();
        }

        public void Move(double deltaX, double deltaY)
        {
            foreach (var point in Points)
            {
                point.Move(deltaX, deltaY);
            }
        }

        public Polygon Clone()
        {
            return new Polygon(Points.ToArray());
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public readonly IEnumerable<Point> Points;
    }
}
