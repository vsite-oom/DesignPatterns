namespace DesignPatterns.AbstractFactory
{
    internal abstract class Shape
    {
        protected Shape(Rectangle bounds, Pen outlinePen, Brush fillBrush)
        {
            this.bounds = bounds;
            this.outlinePen = outlinePen;
            this.fillBrush = fillBrush;
        }

        public abstract void Draw(Graphics g);

        protected readonly Rectangle bounds;
        protected readonly Pen outlinePen;
        protected readonly Brush fillBrush;
    }

    internal class RectangleShape : Shape
    {
        public RectangleShape(Rectangle bounds, Pen outlinePen, Brush fillBrush) : base(bounds, outlinePen, fillBrush)
        {

        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(fillBrush, bounds);
            g.DrawRectangle(outlinePen, bounds);
        }
    }

    // TODO: 012a Add EllipseShape derived from Shape class.

    // TODO: 012b Extend ShapesFactory classes with CreateEllipses methods.


    internal abstract class AbstractShapesFactory
    {
        public IEnumerable<Shape> CreateRectangles(IEnumerable<Rectangle> bounds)
        {
            return PrepareRectangles(bounds);
        }

        protected virtual IEnumerable<Shape> CreateRectangles(IEnumerable<Rectangle> bounds, Pen pen, Brush brush)
        {
            var rectangles = new List<Shape>();
            foreach (var bound in bounds)
            {
                rectangles.Add(new RectangleShape(bound, pen, brush));
            }
            return rectangles;
        } 
        protected virtual IEnumerable<Shape> CreateElipses(IEnumerable<Rectangle> bounds, Pen pen, Brush brush)
        {
            var elipses = new List<Shape>();
            foreach (var bound in bounds)
            {
                elipses.Add(new EllipsesShape(bound, pen, brush));
            }
            return elipses;
        }

        protected abstract IEnumerable<Shape> PrepareRectangles(IEnumerable<Rectangle> bounds);
        protected abstract IEnumerable<Shape> PrepareElipses(IEnumerable<Rectangle> bounds);
    }

    internal class DraftShapesFactory : AbstractShapesFactory
    {
        protected override IEnumerable<Shape> PrepareRectangles(IEnumerable<Rectangle> bounds)
        {
            var pen = new Pen(Color.Black);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            return CreateRectangles(bounds, pen, Brushes.Transparent);
        } 
        protected override IEnumerable<Shape> PrepareElipses(IEnumerable<Rectangle> bounds)
        {
            var pen = new Pen(Color.Black);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            return CreateElipses(bounds, pen, Brushes.Transparent);
        }
    }

    internal class FilledShapesFactory : AbstractShapesFactory
    {
        protected override IEnumerable<Shape> PrepareRectangles(IEnumerable<Rectangle> bounds)
        {
            return CreateRectangles(bounds, Pens.Blue, Brushes.LightGoldenrodYellow);
        } 
        protected override IEnumerable<Shape> PrepareElipses(IEnumerable<Rectangle> bounds)
        {
            return CreateElipses(bounds, Pens.Red, Brushes.Black);
        }
    }

}
