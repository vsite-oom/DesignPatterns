namespace DesignPatterns.Decorator
{
    public partial class FormMain : Form
    {
        private DecoratedShape shape = new DecoratedShape(30, 20, 350, 150);

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            ShapeDecorator dec = new ShapeDecorator(shape);

            if (checkBoxRectangleOutline.Checked)
            {
                dec = new RectangleOutline(dec);
            }
            if (checkBoxRectangleFill.Checked)
            {
                dec = new RectangleFill(dec);
            }
            if (checkBoxEllipseFill.Checked)
            {
                dec = new EllipseFill(dec);
            }
            if (checkBoxEllipseOutline.Checked)
            {
                dec = new EllipseOutline(dec);
            }
            if (checkBoxCaption.Checked)
            {
                dec = new ShapeCaption(dec);
            }

            drawingPane.Assign(dec);
            drawingPane.Invalidate();
        }
    }
}
