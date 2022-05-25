
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
            this.checkBoxEllipseOutline = new System.Windows.Forms.CheckBox();
            this.checkBoxEllipseFill = new System.Windows.Forms.CheckBox();
            this.checkBoxCaption = new System.Windows.Forms.CheckBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.drawingPane = new DesignPatterns.Decorator.DrawingPane();
            this.checkBoxRecOut = new System.Windows.Forms.CheckBox();
            this.checkBoxRecFil = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPane)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEllipseOutline
            // 
            this.checkBoxEllipseOutline.AutoSize = true;
            this.checkBoxEllipseOutline.Location = new System.Drawing.Point(12, 12);
            this.checkBoxEllipseOutline.Name = "checkBoxEllipseOutline";
            this.checkBoxEllipseOutline.Size = new System.Drawing.Size(90, 17);
            this.checkBoxEllipseOutline.TabIndex = 0;
            this.checkBoxEllipseOutline.Text = "&Ellipse outline";
            this.checkBoxEllipseOutline.UseVisualStyleBackColor = true;
            // 
            // checkBoxEllipseFill
            // 
            this.checkBoxEllipseFill.AutoSize = true;
            this.checkBoxEllipseFill.Location = new System.Drawing.Point(12, 35);
            this.checkBoxEllipseFill.Name = "checkBoxEllipseFill";
            this.checkBoxEllipseFill.Size = new System.Drawing.Size(68, 17);
            this.checkBoxEllipseFill.TabIndex = 1;
            this.checkBoxEllipseFill.Text = "Ellipse &fill";
            this.checkBoxEllipseFill.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaption
            // 
            this.checkBoxCaption.AutoSize = true;
            this.checkBoxCaption.Location = new System.Drawing.Point(12, 58);
            this.checkBoxCaption.Name = "checkBoxCaption";
            this.checkBoxCaption.Size = new System.Drawing.Size(62, 17);
            this.checkBoxCaption.TabIndex = 2;
            this.checkBoxCaption.Text = "&Caption";
            this.checkBoxCaption.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 243);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 3;
            this.buttonDraw.Text = "&Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // drawingPane
            // 
            this.drawingPane.BackColor = System.Drawing.SystemColors.Window;
            this.drawingPane.Location = new System.Drawing.Point(154, 12);
            this.drawingPane.Name = "drawingPane";
            this.drawingPane.Size = new System.Drawing.Size(422, 254);
            this.drawingPane.TabIndex = 4;
            this.drawingPane.TabStop = false;
            // 
            // checkBoxRecOut
            // 
            this.checkBoxRecOut.AutoSize = true;
            this.checkBoxRecOut.Location = new System.Drawing.Point(12, 81);
            this.checkBoxRecOut.Name = "checkBoxRecOut";
            this.checkBoxRecOut.Size = new System.Drawing.Size(109, 17);
            this.checkBoxRecOut.TabIndex = 5;
            this.checkBoxRecOut.Text = "&Rectangle outline";
            this.checkBoxRecOut.UseVisualStyleBackColor = true;
            // 
            // checkBoxRecFil
            // 
            this.checkBoxRecFil.AutoSize = true;
            this.checkBoxRecFil.Location = new System.Drawing.Point(12, 104);
            this.checkBoxRecFil.Name = "checkBoxRecFil";
            this.checkBoxRecFil.Size = new System.Drawing.Size(87, 17);
            this.checkBoxRecFil.TabIndex = 6;
            this.checkBoxRecFil.Text = "Rectangle &fill";
            this.checkBoxRecFil.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 278);
            this.Controls.Add(this.checkBoxRecFil);
            this.Controls.Add(this.checkBoxRecOut);
            this.Controls.Add(this.drawingPane);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.checkBoxCaption);
            this.Controls.Add(this.checkBoxEllipseFill);
            this.Controls.Add(this.checkBoxEllipseOutline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Ellipse Decorator";
            ((System.ComponentModel.ISupportInitialize)(this.drawingPane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEllipseOutline;
        private System.Windows.Forms.CheckBox checkBoxEllipseFill;
        private System.Windows.Forms.CheckBox checkBoxCaption;
        private System.Windows.Forms.Button buttonDraw;
        private DrawingPane drawingPane;
        private System.Windows.Forms.CheckBox checkBoxRecOut;
        private System.Windows.Forms.CheckBox checkBoxRecFil;
    }
}

