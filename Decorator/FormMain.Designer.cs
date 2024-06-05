
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
            checkBoxEllipseFill.CheckedChanged += this.checkBoxEllipseFill_CheckedChanged;
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
            checkBoxCaption.CheckedChanged += checkBoxCaption_CheckedChanged;
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 535);
            Controls.Add(buttonDraw);
            Controls.Add(checkBoxCaption);
            Controls.Add(checkBoxEllipseFill);
            Controls.Add(checkBoxEllipseOutline);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Ellipse Decorator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEllipseOutline;
        private System.Windows.Forms.CheckBox checkBoxEllipseFill;
        private System.Windows.Forms.CheckBox checkBoxCaption;
        private System.Windows.Forms.Button buttonDraw;
        private DrawingPane drawingPane;
    }
}

