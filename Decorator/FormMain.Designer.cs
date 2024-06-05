
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
            checkBoxRectangleOutline = new CheckBox();
            checkBoxRectangleFill = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)drawingPane).BeginInit();
            SuspendLayout();
            // 
            // checkBoxEllipseOutline
            // 
            checkBoxEllipseOutline.AutoSize = true;
            checkBoxEllipseOutline.Location = new Point(14, 14);
            checkBoxEllipseOutline.Margin = new Padding(4, 3, 4, 3);
            checkBoxEllipseOutline.Name = "checkBoxEllipseOutline";
            checkBoxEllipseOutline.Size = new Size(99, 19);
            checkBoxEllipseOutline.TabIndex = 0;
            checkBoxEllipseOutline.Text = "&Ellipse outline";
            checkBoxEllipseOutline.UseVisualStyleBackColor = true;
            // 
            // checkBoxEllipseFill
            // 
            checkBoxEllipseFill.AutoSize = true;
            checkBoxEllipseFill.Location = new Point(14, 40);
            checkBoxEllipseFill.Margin = new Padding(4, 3, 4, 3);
            checkBoxEllipseFill.Name = "checkBoxEllipseFill";
            checkBoxEllipseFill.Size = new Size(75, 19);
            checkBoxEllipseFill.TabIndex = 1;
            checkBoxEllipseFill.Text = "Ellipse &fill";
            checkBoxEllipseFill.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaption
            // 
            checkBoxCaption.AutoSize = true;
            checkBoxCaption.Location = new Point(14, 67);
            checkBoxCaption.Margin = new Padding(4, 3, 4, 3);
            checkBoxCaption.Name = "checkBoxCaption";
            checkBoxCaption.Size = new Size(68, 19);
            checkBoxCaption.TabIndex = 2;
            checkBoxCaption.Text = "&Caption";
            checkBoxCaption.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(14, 280);
            buttonDraw.Margin = new Padding(4, 3, 4, 3);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(88, 27);
            buttonDraw.TabIndex = 3;
            buttonDraw.Text = "&Draw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // drawingPane
            // 
            drawingPane.BackColor = SystemColors.Window;
            drawingPane.Location = new Point(180, 14);
            drawingPane.Margin = new Padding(4, 3, 4, 3);
            drawingPane.Name = "drawingPane";
            drawingPane.Size = new Size(492, 293);
            drawingPane.TabIndex = 4;
            drawingPane.TabStop = false;
            // 
            // checkBoxRectangleOutline
            // 
            checkBoxRectangleOutline.AutoSize = true;
            checkBoxRectangleOutline.Location = new Point(14, 94);
            checkBoxRectangleOutline.Name = "checkBoxRectangleOutline";
            checkBoxRectangleOutline.Size = new Size(118, 19);
            checkBoxRectangleOutline.TabIndex = 5;
            checkBoxRectangleOutline.Text = "&Rectangle outline";
            checkBoxRectangleOutline.UseVisualStyleBackColor = true;
            // 
            // checkBoxRectangleFill
            // 
            checkBoxRectangleFill.AutoSize = true;
            checkBoxRectangleFill.Location = new Point(14, 121);
            checkBoxRectangleFill.Name = "checkBoxRectangleFill";
            checkBoxRectangleFill.Size = new Size(94, 19);
            checkBoxRectangleFill.TabIndex = 6;
            checkBoxRectangleFill.Text = "R&ectangle fill";
            checkBoxRectangleFill.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 321);
            Controls.Add(checkBoxRectangleFill);
            Controls.Add(checkBoxRectangleOutline);
            Controls.Add(drawingPane);
            Controls.Add(buttonDraw);
            Controls.Add(checkBoxCaption);
            Controls.Add(checkBoxEllipseFill);
            Controls.Add(checkBoxEllipseOutline);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
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
        private CheckBox checkBoxRectangleOutline;
        private CheckBox checkBoxRectangleFill;
    }
}

