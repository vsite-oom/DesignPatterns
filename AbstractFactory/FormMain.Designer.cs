namespace DesignPatterns.AbstractFactory
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxStyle = new GroupBox();
            radioButtonFilledStyle = new RadioButton();
            radioButtonDraftStyle = new RadioButton();
            drawingPane = new DrawingPane();
            groupBoxStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drawingPane).BeginInit();
            SuspendLayout();
            // 
            // groupBoxStyle
            // 
            groupBoxStyle.Controls.Add(radioButtonFilledStyle);
            groupBoxStyle.Controls.Add(radioButtonDraftStyle);
            groupBoxStyle.Location = new Point(12, 12);
            groupBoxStyle.Name = "groupBoxStyle";
            groupBoxStyle.Size = new Size(123, 78);
            groupBoxStyle.TabIndex = 0;
            groupBoxStyle.TabStop = false;
            groupBoxStyle.Text = "Shapes style";
            // 
            // radioButtonFilledStyle
            // 
            radioButtonFilledStyle.AutoSize = true;
            radioButtonFilledStyle.Location = new Point(6, 47);
            radioButtonFilledStyle.Name = "radioButtonFilledStyle";
            radioButtonFilledStyle.Size = new Size(81, 19);
            radioButtonFilledStyle.TabIndex = 1;
            radioButtonFilledStyle.TabStop = true;
            radioButtonFilledStyle.Text = "&Filled Style";
            radioButtonFilledStyle.UseVisualStyleBackColor = true;
            radioButtonFilledStyle.CheckedChanged += radioButtonStyle_CheckedChanged;
            // 
            // radioButtonDraftStyle
            // 
            radioButtonDraftStyle.AutoSize = true;
            radioButtonDraftStyle.Location = new Point(6, 22);
            radioButtonDraftStyle.Name = "radioButtonDraftStyle";
            radioButtonDraftStyle.Size = new Size(51, 19);
            radioButtonDraftStyle.TabIndex = 0;
            radioButtonDraftStyle.TabStop = true;
            radioButtonDraftStyle.Text = "&Draft";
            radioButtonDraftStyle.UseVisualStyleBackColor = true;
            radioButtonDraftStyle.CheckedChanged += radioButtonStyle_CheckedChanged;
            // 
            // drawingPane
            // 
            drawingPane.BackColor = SystemColors.Window;
            drawingPane.Location = new Point(141, 12);
            drawingPane.Name = "drawingPane";
            drawingPane.Size = new Size(647, 426);
            drawingPane.TabIndex = 1;
            drawingPane.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(drawingPane);
            Controls.Add(groupBoxStyle);
            Name = "FormMain";
            Text = "Abstract Factory";
            groupBoxStyle.ResumeLayout(false);
            groupBoxStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)drawingPane).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxStyle;
        private RadioButton radioButtonFilledStyle;
        private RadioButton radioButtonDraftStyle;
        private DrawingPane drawingPane;
    }
}