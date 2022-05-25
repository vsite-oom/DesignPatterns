﻿
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
            this.checkBoxRectangleFill = new System.Windows.Forms.CheckBox();
            this.checkBoxRectangleOutLine = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPane)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEllipseOutline
            // 
            this.checkBoxEllipseOutline.AutoSize = true;
            this.checkBoxEllipseOutline.Location = new System.Drawing.Point(16, 15);
            this.checkBoxEllipseOutline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEllipseOutline.Name = "checkBoxEllipseOutline";
            this.checkBoxEllipseOutline.Size = new System.Drawing.Size(117, 21);
            this.checkBoxEllipseOutline.TabIndex = 0;
            this.checkBoxEllipseOutline.Text = "&Ellipse outline";
            this.checkBoxEllipseOutline.UseVisualStyleBackColor = true;
            // 
            // checkBoxEllipseFill
            // 
            this.checkBoxEllipseFill.AutoSize = true;
            this.checkBoxEllipseFill.Location = new System.Drawing.Point(16, 43);
            this.checkBoxEllipseFill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEllipseFill.Name = "checkBoxEllipseFill";
            this.checkBoxEllipseFill.Size = new System.Drawing.Size(88, 21);
            this.checkBoxEllipseFill.TabIndex = 1;
            this.checkBoxEllipseFill.Text = "Ellipse &fill";
            this.checkBoxEllipseFill.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaption
            // 
            this.checkBoxCaption.AutoSize = true;
            this.checkBoxCaption.Location = new System.Drawing.Point(16, 71);
            this.checkBoxCaption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxCaption.Name = "checkBoxCaption";
            this.checkBoxCaption.Size = new System.Drawing.Size(78, 21);
            this.checkBoxCaption.TabIndex = 2;
            this.checkBoxCaption.Text = "&Caption";
            this.checkBoxCaption.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(16, 299);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(100, 28);
            this.buttonDraw.TabIndex = 3;
            this.buttonDraw.Text = "&Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // drawingPane
            // 
            this.drawingPane.BackColor = System.Drawing.SystemColors.Window;
            this.drawingPane.Location = new System.Drawing.Point(205, 15);
            this.drawingPane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawingPane.Name = "drawingPane";
            this.drawingPane.Size = new System.Drawing.Size(563, 313);
            this.drawingPane.TabIndex = 4;
            this.drawingPane.TabStop = false;
            // 
            // checkBoxRectangleFill
            // 
            this.checkBoxRectangleFill.AutoSize = true;
            this.checkBoxRectangleFill.Location = new System.Drawing.Point(13, 129);
            this.checkBoxRectangleFill.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRectangleFill.Name = "checkBoxRectangleFill";
            this.checkBoxRectangleFill.Size = new System.Drawing.Size(111, 21);
            this.checkBoxRectangleFill.TabIndex = 5;
            this.checkBoxRectangleFill.Text = "Rectangle fill";
            this.checkBoxRectangleFill.UseVisualStyleBackColor = true;
            // 
            // checkBoxRectangleOutLine
            // 
            this.checkBoxRectangleOutLine.AutoSize = true;
            this.checkBoxRectangleOutLine.Location = new System.Drawing.Point(13, 100);
            this.checkBoxRectangleOutLine.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRectangleOutLine.Name = "checkBoxRectangleOutLine";
            this.checkBoxRectangleOutLine.Size = new System.Drawing.Size(140, 21);
            this.checkBoxRectangleOutLine.TabIndex = 6;
            this.checkBoxRectangleOutLine.Text = "&Rectangle outline";
            this.checkBoxRectangleOutLine.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 342);
            this.Controls.Add(this.checkBoxRectangleOutLine);
            this.Controls.Add(this.checkBoxRectangleFill);
            this.Controls.Add(this.drawingPane);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.checkBoxCaption);
            this.Controls.Add(this.checkBoxEllipseFill);
            this.Controls.Add(this.checkBoxEllipseOutline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.CheckBox checkBoxRectangleFill;
        private System.Windows.Forms.CheckBox checkBoxRectangleOutLine;
    }
}

