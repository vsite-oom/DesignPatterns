
namespace DesignPatterns.Singleton
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
            button1 = new Button();
            textBoxData = new TextBox();
            label1 = new Label();
            buttonClear = new Button();
            buttonNew = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 84);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 36);
            button1.TabIndex = 0;
            button1.Text = "&Get data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(67, 19);
            textBoxData.Margin = new Padding(5, 4, 5, 4);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(173, 27);
            textBoxData.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 2;
            label1.Text = "&Data:";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(143, 84);
            buttonClear.Margin = new Padding(5, 4, 5, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(101, 36);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "&Clear data";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(21, 127);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(94, 29);
            buttonNew.TabIndex = 4;
            buttonNew.Text = "&New...";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 190);
            Controls.Add(buttonNew);
            Controls.Add(buttonClear);
            Controls.Add(label1);
            Controls.Add(textBoxData);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxData;
        private Label label1;
        private Button buttonClear;
        private Button buttonNew;
    }
}

