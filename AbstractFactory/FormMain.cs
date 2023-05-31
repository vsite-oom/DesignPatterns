namespace DesignPatterns.AbstractFactory
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private AbstractShapesFactory shapesFactory = null;

        private void radioButtonStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDraftStyle.Checked)
            {
                shapesFactory = new DraftShapesFactory();
            }
            if (radioButtonFilledStyle.Checked)
            {
                shapesFactory = new FilledShapesFactory();
            }
            List<Shape> shapes = new List<Shape>(shapesFactory.CreateRectangles(rectangleBounds));
            shapes.AddRange(shapesFactory.CreateEllipses(ellipseBounds));
            drawingPane.Assign(shapes);

        }

        Rectangle[] rectangleBounds = { new Rectangle(100, 50, 200, 40), new Rectangle(140, 20, 90, 30) };
        Rectangle[] ellipseBounds = { new Rectangle(120, 80, 40, 40), new Rectangle(240,80, 40, 40) };
    }
}