
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
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(18, 63);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 0;
            button1.Text = "&Get data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(59, 14);
            textBoxData.Margin = new Padding(4, 3, 4, 3);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(152, 23);
            textBoxData.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "&Data:";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(125, 63);
            buttonClear.Margin = new Padding(4, 3, 4, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(88, 27);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "&Clear data";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // button2
            // 
            button2.Location = new Point(18, 120);
            button2.Name = "button2";
            button2.Size = new Size(195, 30);
            button2.TabIndex = 4;
            button2.Text = "New Window";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonNewForm_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 162);
            Controls.Add(button2);
            Controls.Add(buttonClear);
            Controls.Add(label1);
            Controls.Add(textBoxData);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
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
        private Button button2;
    }
}

