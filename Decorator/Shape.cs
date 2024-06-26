﻿namespace DesignPatterns.Decorator
{
    abstract class Shape
    {
        public abstract void Draw(Graphics g);

        public abstract Rectangle Bounds { get; }
    }

    class DecoratedShape : Shape
    {
        public DecoratedShape(int x, int y, int width, int height)
        {
            Bounds = new Rectangle(x, y, width, height);
        }
        public override void Draw(Graphics g) { }

        public override Rectangle Bounds { get; }

    }

    class ShapeDecorator : Shape
    {
        protected readonly Shape shape;
        public ShapeDecorator(Shape shape)
        {
            this.shape = shape;
        }

        public override void Draw(Graphics g)
        {
            shape.Draw(g);
        }

        public override Rectangle Bounds => shape.Bounds;
    }

    class EllipseOutline : ShapeDecorator
    {
        public EllipseOutline(Shape shape) : base(shape)
        {
        }

        public override void Draw(Graphics g)
        {
            shape.Draw(g);
            g.DrawEllipse(Pens.Black, shape.Bounds);
        }
    }
    class EllipseFill : ShapeDecorator
    {
        public EllipseFill(Shape shape) : base(shape)
        {
        }

        public override void Draw(Graphics g)
        {
            shape.Draw(g);
            g.FillEllipse(Brushes.Cyan, shape.Bounds);
        }
    }
    class ShapeCaption : ShapeDecorator
    {
        public ShapeCaption(Shape shape) : base(shape)
        {
        }

        public override void Draw(Graphics g)
        {
            shape.Draw(g);
            var pos = new Point(shape.Bounds.X + shape.Bounds.Width / 2, shape.Bounds.Y + shape.Bounds.Height / 2);
            g.DrawString("A", SystemFonts.CaptionFont!, Brushes.Red, pos);
        }
    }

    // TODO: 2.3a Create RectangleOutline and RectangleFill decorators.

    // TODO: 2.3b Add two new checkboxes to the main form that will activate these decorators.
}
