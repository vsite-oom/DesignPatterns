namespace DesignPatterns.Decorator
{
    class DrawingPane : System.Windows.Forms.PictureBox
    {
        private Shape shape = null;

        public void Assign(Shape shape)
        {
            this.shape = shape;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (shape != null)
            {
                shape.Draw(pe.Graphics);
            }
        }
    }
}
