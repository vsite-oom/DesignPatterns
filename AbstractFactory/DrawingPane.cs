namespace DesignPatterns.AbstractFactory
{
    class DrawingPane : PictureBox
    {
        private List<Shape> shapes = new List<Shape>();

        public void Assign(List<Shape> shapes)
        {
            this.shapes = shapes;
            Invalidate();
        }
        public void Add(IEnumerable<Shape> shapes)
        {
            this.shapes.AddRange(shapes);
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
