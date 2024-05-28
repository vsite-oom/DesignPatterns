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

        }

        Rectangle[] rectangleBounds = { new Rectangle(100, 50, 200, 40), new Rectangle(140, 20, 90, 30) };
    }
}