namespace DesignPatterns.AbstractFactory
{
    class DrawingPane : PictureBox
    {
        private IEnumerable<Shape> shapes = new List<Shape>();

        public void Assign(IEnumerable<Shape> shapes)
        {
            this.shapes = shapes;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            foreach (var shape in shapes)
            {
                shape.Draw(pe.Graphics);
            }
        }
    }
}
