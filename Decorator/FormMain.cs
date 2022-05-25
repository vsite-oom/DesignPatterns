using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (checkBoxRectangleFill.Checked)
            {
                dec = new RectangleFill(dec);
            }
            if (checkBoxRectangleOutline.Checked)
            {
                dec = new RectangleOutline(dec);
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
           
            drawingPane1.Assign(dec);
            drawingPane1.Invalidate();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
