namespace DesignPatterns.Proxy
{
    partial class RequestForm
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
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxFamilyName = new TextBox();
            label2 = new Label();
            buttonGet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "&Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(107, 16);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(229, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxFamilyName
            // 
            textBoxFamilyName.Location = new Point(107, 55);
            textBoxFamilyName.Margin = new Padding(3, 4, 3, 4);
            textBoxFamilyName.Name = "textBoxFamilyName";
            textBoxFamilyName.ReadOnly = true;
            textBoxFamilyName.Size = new Size(229, 27);
            textBoxFamilyName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 59);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 2;
            label2.Text = "&Family name:";
            // 
            // buttonGet
            // 
            buttonGet.Location = new Point(251, 119);
            buttonGet.Margin = new Padding(3, 4, 3, 4);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(86, 31);
            buttonGet.TabIndex = 6;
            buttonGet.Text = "&Get";
            buttonGet.UseVisualStyleBackColor = true;
            buttonGet.Click += buttonGet_Click;
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 165);
            Controls.Add(buttonGet);
            Controls.Add(textBoxFamilyName);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "RequestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Proxy";
            Load += RequestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxFamilyName;
        private Label label2;
        private Button buttonGet;
    }
}