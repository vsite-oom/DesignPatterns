
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
            this.checkBoxOutline = new System.Windows.Forms.CheckBox();
            this.checkBoxFill = new System.Windows.Forms.CheckBox();
            this.checkBoxCaption = new System.Windows.Forms.CheckBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.drawingPane = new DesignPatterns.Decorator.DrawingPane();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPane)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxOutline
            // 
            this.checkBoxOutline.AutoSize = true;
            this.checkBoxOutline.Location = new System.Drawing.Point(12, 12);
            this.checkBoxOutline.Name = "checkBoxOutline";
            this.checkBoxOutline.Size = new System.Drawing.Size(59, 17);
            this.checkBoxOutline.TabIndex = 0;
            this.checkBoxOutline.Text = "&Outline";
            this.checkBoxOutline.UseVisualStyleBackColor = true;
            // 
            // checkBoxFill
            // 
            this.checkBoxFill.AutoSize = true;
            this.checkBoxFill.Location = new System.Drawing.Point(12, 35);
            this.checkBoxFill.Name = "checkBoxFill";
            this.checkBoxFill.Size = new System.Drawing.Size(38, 17);
            this.checkBoxFill.TabIndex = 1;
            this.checkBoxFill.Text = "&Fill";
            this.checkBoxFill.UseVisualStyleBackColor = true;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 278);
            this.Controls.Add(this.drawingPane);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.checkBoxCaption);
            this.Controls.Add(this.checkBoxFill);
            this.Controls.Add(this.checkBoxOutline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Ellipse Decorator";
            ((System.ComponentModel.ISupportInitialize)(this.drawingPane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxOutline;
        private System.Windows.Forms.CheckBox checkBoxFill;
        private System.Windows.Forms.CheckBox checkBoxCaption;
        private System.Windows.Forms.Button buttonDraw;
        private DrawingPane drawingPane;
    }
}

