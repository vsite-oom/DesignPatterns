
namespace DesignPatterns.Singleton
{
    partial class LoginForm
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
            label1 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            textBoxPassword = new TextBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 48);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "&Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(127, 43);
            textBoxUsername.Margin = new Padding(5, 4, 5, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(132, 27);
            textBoxUsername.TabIndex = 1;
            textBoxUsername.TextChanged += textBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 100);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "&Password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(127, 96);
            textBoxPassword.Margin = new Padding(5, 4, 5, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(132, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBox_TextChanged;
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Enabled = false;
            buttonOK.Location = new Point(46, 189);
            buttonOK.Margin = new Padding(5, 4, 5, 4);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(101, 36);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(160, 189);
            buttonCancel.Margin = new Padding(5, 4, 5, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(101, 36);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "&Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(314, 249);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxUsername;
        private Label label2;
        private TextBox textBoxPassword;
        private Button buttonOK;
        private Button buttonCancel;
    }
}