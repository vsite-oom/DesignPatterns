namespace DesignPatterns.AbstractFactory
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private AbstractShapesFactory? shapesFactory;

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
            drawingPane.Assign(shapesFactory!.CreateEllipses(ellipseBounds));
            drawingPane.Add(shapesFactory!.CreateRectangles(rectangleBounds));
        }

        Rectangle[] rectangleBounds = { new Rectangle(100, 50, 200, 40), new Rectangle(140, 20, 90, 30) };
        Rectangle[] ellipseBounds = { new Rectangle(200, 30, 100, 20), new Rectangle(110, 30, 100, 30) };

    }
}