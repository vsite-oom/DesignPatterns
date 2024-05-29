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
            drawingPane.Assign(shapesFactory!.CreateRectangles(rectangleBounds));
            drawingPane.Assign(shapesFactory!.CreateEllipses(ellipseBounds));

        }

        Rectangle[] rectangleBounds = { new Rectangle(100, 50, 200, 40), new Rectangle(140, 20, 90, 30) };
        Rectangle[] ellipseBounds = { new Rectangle(200, 30, 120, 30), new Rectangle(240, 20, 20, 20) };
    }
}