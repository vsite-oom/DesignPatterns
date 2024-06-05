
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
            drawingPane = new DrawingPane();
            cbRectangleOutline = new CheckBox();
            cbRectangleFill = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)drawingPane).BeginInit();
            SuspendLayout();
            // 
            // checkBoxEllipseOutline
            // 
            checkBoxEllipseOutline.AutoSize = true;
            checkBoxEllipseOutline.Location = new Point(20, 23);
            checkBoxEllipseOutline.Margin = new Padding(5, 6, 5, 6);
            checkBoxEllipseOutline.Name = "checkBoxEllipseOutline";
            checkBoxEllipseOutline.Size = new Size(146, 29);
            checkBoxEllipseOutline.TabIndex = 0;
            checkBoxEllipseOutline.Text = "&Ellipse outline";
            checkBoxEllipseOutline.UseVisualStyleBackColor = true;
            // 
            // checkBoxEllipseFill
            // 
            checkBoxEllipseFill.AutoSize = true;
            checkBoxEllipseFill.Location = new Point(20, 67);
            checkBoxEllipseFill.Margin = new Padding(5, 6, 5, 6);
            checkBoxEllipseFill.Name = "checkBoxEllipseFill";
            checkBoxEllipseFill.Size = new Size(110, 29);
            checkBoxEllipseFill.TabIndex = 1;
            checkBoxEllipseFill.Text = "Ellipse &fill";
            checkBoxEllipseFill.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaption
            // 
            checkBoxCaption.AutoSize = true;
            checkBoxCaption.Location = new Point(20, 112);
            checkBoxCaption.Margin = new Padding(5, 6, 5, 6);
            checkBoxCaption.Name = "checkBoxCaption";
            checkBoxCaption.Size = new Size(100, 29);
            checkBoxCaption.TabIndex = 2;
            checkBoxCaption.Text = "&Caption";
            checkBoxCaption.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(20, 467);
            buttonDraw.Margin = new Padding(5, 6, 5, 6);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(125, 44);
            buttonDraw.TabIndex = 3;
            buttonDraw.Text = "&Draw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // drawingPane
            // 
            drawingPane.BackColor = SystemColors.Window;
            drawingPane.Location = new Point(257, 23);
            drawingPane.Margin = new Padding(5, 6, 5, 6);
            drawingPane.Name = "drawingPane";
            drawingPane.Size = new Size(703, 488);
            drawingPane.TabIndex = 4;
            drawingPane.TabStop = false;
            // 
            // cbRectangleOutline
            // 
            cbRectangleOutline.AutoSize = true;
            cbRectangleOutline.Location = new Point(20, 153);
            cbRectangleOutline.Margin = new Padding(5, 6, 5, 6);
            cbRectangleOutline.Name = "cbRectangleOutline";
            cbRectangleOutline.Size = new Size(176, 29);
            cbRectangleOutline.TabIndex = 5;
            cbRectangleOutline.Text = "Rectangle Outline";
            cbRectangleOutline.UseVisualStyleBackColor = true;
            // 
            // cbRectangleFill
            // 
            cbRectangleFill.AutoSize = true;
            cbRectangleFill.Location = new Point(20, 194);
            cbRectangleFill.Margin = new Padding(5, 6, 5, 6);
            cbRectangleFill.Name = "cbRectangleFill";
            cbRectangleFill.Size = new Size(140, 29);
            cbRectangleFill.TabIndex = 6;
            cbRectangleFill.Text = "Rectangle Fill";
            cbRectangleFill.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 535);
            Controls.Add(cbRectangleFill);
            Controls.Add(cbRectangleOutline);
            Controls.Add(drawingPane);
            Controls.Add(buttonDraw);
            Controls.Add(checkBoxCaption);
            Controls.Add(checkBoxEllipseFill);
            Controls.Add(checkBoxEllipseOutline);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Ellipse Decorator";
            ((System.ComponentModel.ISupportInitialize)drawingPane).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEllipseOutline;
        private System.Windows.Forms.CheckBox checkBoxEllipseFill;
        private System.Windows.Forms.CheckBox checkBoxCaption;
        private System.Windows.Forms.Button buttonDraw;
        private DrawingPane drawingPane;
        private CheckBox cbRectangleOutline;
        private CheckBox cbRectangleFill;
    }
}

