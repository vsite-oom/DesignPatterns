using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
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
    
    class RectangleOutline : ShapeDecorator
    {
        public RectangleOutline(Shape shape) : base(shape)
        {
        }

        public override void Draw(Graphics g)
        {
            shape.Draw(g);
            g.DrawRectangle(Pens.Blue, shape.Bounds);
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

    class RectangleFill : ShapeDecorator
    {
        public RectangleFill(Shape shape) : base(shape)
        {
        }

        public override void Draw(Graphics g)
        {
            shape.Draw(g);
            g.FillRectangle(Brushes.IndianRed, shape.Bounds);
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
            g.DrawString("A", SystemFonts.CaptionFont, Brushes.Red, pos);
        }
    }

}
