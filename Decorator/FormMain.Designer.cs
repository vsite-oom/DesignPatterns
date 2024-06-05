
namespace DesignPatterns.Decorator
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxEllipseOutline = new CheckBox();
            checkBoxEllipseFill = new CheckBox();
            checkBoxCaption = new CheckBox();
            buttonDraw = new Button();
            rectangleOutline = new CheckBox();
            rectangleFill = new CheckBox();
            SuspendLayout();
            // 
            // checkBoxEllipseOutline
            // 
            checkBoxEllipseOutline.AutoSize = true;
            checkBoxEllipseOutline.Location = new Point(16, 18);
            checkBoxEllipseOutline.Margin = new Padding(4, 5, 4, 5);
            checkBoxEllipseOutline.Name = "checkBoxEllipseOutline";
            checkBoxEllipseOutline.Size = new Size(124, 24);
            checkBoxEllipseOutline.TabIndex = 0;
            checkBoxEllipseOutline.Text = "&Ellipse outline";
            checkBoxEllipseOutline.UseVisualStyleBackColor = true;
            // 
            // checkBoxEllipseFill
            // 
            checkBoxEllipseFill.AutoSize = true;
            checkBoxEllipseFill.Location = new Point(16, 54);
            checkBoxEllipseFill.Margin = new Padding(4, 5, 4, 5);
            checkBoxEllipseFill.Name = "checkBoxEllipseFill";
            checkBoxEllipseFill.Size = new Size(95, 24);
            checkBoxEllipseFill.TabIndex = 1;
            checkBoxEllipseFill.Text = "Ellipse &fill";
            checkBoxEllipseFill.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaption
            // 
            checkBoxCaption.AutoSize = true;
            checkBoxCaption.Location = new Point(16, 89);
            checkBoxCaption.Margin = new Padding(4, 5, 4, 5);
            checkBoxCaption.Name = "checkBoxCaption";
            checkBoxCaption.Size = new Size(83, 24);
            checkBoxCaption.TabIndex = 2;
            checkBoxCaption.Text = "&Caption";
            checkBoxCaption.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(16, 374);
            buttonDraw.Margin = new Padding(4, 5, 4, 5);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(100, 35);
            buttonDraw.TabIndex = 3;
            buttonDraw.Text = "&Draw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // rectangleOutline
            // 
            rectangleOutline.AutoSize = true;
            rectangleOutline.Location = new Point(16, 142);
            rectangleOutline.Name = "rectangleOutline";
            rectangleOutline.Size = new Size(147, 24);
            rectangleOutline.TabIndex = 4;
            rectangleOutline.Text = "Rectangle outline";
            rectangleOutline.UseVisualStyleBackColor = true;
            // 
            // rectangleFill
            // 
            rectangleFill.AutoSize = true;
            rectangleFill.Location = new Point(12, 184);
            rectangleFill.Name = "rectangleFill";
            rectangleFill.Size = new Size(118, 24);
            rectangleFill.TabIndex = 5;
            rectangleFill.Text = "Rectangle fill";
            rectangleFill.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 428);
            Controls.Add(rectangleFill);
            Controls.Add(rectangleOutline);
            Controls.Add(buttonDraw);
            Controls.Add(checkBoxCaption);
            Controls.Add(checkBoxEllipseFill);
            Controls.Add(checkBoxEllipseOutline);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Ellipse Decorator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxEllipseOutline;
        private CheckBox checkBoxEllipseFill;
        private CheckBox checkBoxCaption;
        private Button buttonDraw;
        private DrawingPane drawingPane;
        private CheckBox rectangleOutline;
        private CheckBox rectangleFill;
    }
}

