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
            groupBoxStyle.Location = new Point(14, 16);
            groupBoxStyle.Margin = new Padding(3, 4, 3, 4);
            groupBoxStyle.Name = "groupBoxStyle";
            groupBoxStyle.Padding = new Padding(3, 4, 3, 4);
            groupBoxStyle.Size = new Size(141, 104);
            groupBoxStyle.TabIndex = 0;
            groupBoxStyle.TabStop = false;
            groupBoxStyle.Text = "Shapes style";
            // 
            // radioButtonFilledStyle
            // 
            radioButtonFilledStyle.AutoSize = true;
            radioButtonFilledStyle.Location = new Point(7, 63);
            radioButtonFilledStyle.Margin = new Padding(3, 4, 3, 4);
            radioButtonFilledStyle.Name = "radioButtonFilledStyle";
            radioButtonFilledStyle.Size = new Size(102, 24);
            radioButtonFilledStyle.TabIndex = 1;
            radioButtonFilledStyle.TabStop = true;
            radioButtonFilledStyle.Text = "&Filled Style";
            radioButtonFilledStyle.UseVisualStyleBackColor = true;
            radioButtonFilledStyle.CheckedChanged += radioButtonStyle_CheckedChanged;
            // 
            // radioButtonDraftStyle
            // 
            radioButtonDraftStyle.AutoSize = true;
            radioButtonDraftStyle.Location = new Point(7, 29);
            radioButtonDraftStyle.Margin = new Padding(3, 4, 3, 4);
            radioButtonDraftStyle.Name = "radioButtonDraftStyle";
            radioButtonDraftStyle.Size = new Size(64, 24);
            radioButtonDraftStyle.TabIndex = 0;
            radioButtonDraftStyle.TabStop = true;
            radioButtonDraftStyle.Text = "&Draft";
            radioButtonDraftStyle.UseVisualStyleBackColor = true;
            radioButtonDraftStyle.CheckedChanged += radioButtonStyle_CheckedChanged;
            // 
            // drawingPane
            // 
            drawingPane.BackColor = SystemColors.Window;
            drawingPane.Location = new Point(161, 16);
            drawingPane.Margin = new Padding(3, 4, 3, 4);
            drawingPane.Name = "drawingPane";
            drawingPane.Size = new Size(739, 568);
            drawingPane.TabIndex = 1;
            drawingPane.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(drawingPane);
            Controls.Add(groupBoxStyle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Abstract Factory";
            Load += FormMain_Load;
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