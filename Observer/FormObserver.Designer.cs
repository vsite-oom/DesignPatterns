
namespace DesignPatterns.Observer
{
    partial class FormObserver
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSubscribed1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxSubscribed2 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxSubscribed3 = new System.Windows.Forms.CheckBox();
            this.textBoxSubscriber3 = new DesignPatterns.Observer.SubscriberTextBox();
            this.textBoxSubscriber2 = new DesignPatterns.Observer.SubscriberTextBox();
            this.textBoxSubscriber1 = new DesignPatterns.Observer.SubscriberTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPublisher);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publisher";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(6, 19);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(220, 20);
            this.textBoxPublisher.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSubscriber1);
            this.groupBox2.Controls.Add(this.checkBoxSubscribed1);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subscriber 1";
            // 
            // checkBoxSubscribed1
            // 
            this.checkBoxSubscribed1.AutoSize = true;
            this.checkBoxSubscribed1.Location = new System.Drawing.Point(6, 19);
            this.checkBoxSubscribed1.Name = "checkBoxSubscribed1";
            this.checkBoxSubscribed1.Size = new System.Drawing.Size(79, 17);
            this.checkBoxSubscribed1.TabIndex = 0;
            this.checkBoxSubscribed1.Text = "Su&bscribed";
            this.checkBoxSubscribed1.UseVisualStyleBackColor = true;
            this.checkBoxSubscribed1.CheckedChanged += new System.EventHandler(this.checkBoxSubscribed1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSubscriber2);
            this.groupBox3.Controls.Add(this.checkBoxSubscribed2);
            this.groupBox3.Location = new System.Drawing.Point(12, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subscriber 2";
            // 
            // checkBoxSubscribed2
            // 
            this.checkBoxSubscribed2.AutoSize = true;
            this.checkBoxSubscribed2.Location = new System.Drawing.Point(6, 19);
            this.checkBoxSubscribed2.Name = "checkBoxSubscribed2";
            this.checkBoxSubscribed2.Size = new System.Drawing.Size(79, 17);
            this.checkBoxSubscribed2.TabIndex = 0;
            this.checkBoxSubscribed2.Text = "Su&bscribed";
            this.checkBoxSubscribed2.UseVisualStyleBackColor = true;
            this.checkBoxSubscribed2.CheckedChanged += new System.EventHandler(this.checkBoxSubscribed2_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxSubscriber3);
            this.groupBox4.Controls.Add(this.checkBoxSubscribed3);
            this.groupBox4.Location = new System.Drawing.Point(12, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 76);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Subscriber 3";
            // 
            // checkBoxSubscribed3
            // 
            this.checkBoxSubscribed3.AutoSize = true;
            this.checkBoxSubscribed3.Location = new System.Drawing.Point(6, 19);
            this.checkBoxSubscribed3.Name = "checkBoxSubscribed3";
            this.checkBoxSubscribed3.Size = new System.Drawing.Size(79, 17);
            this.checkBoxSubscribed3.TabIndex = 0;
            this.checkBoxSubscribed3.Text = "Su&bscribed";
            this.checkBoxSubscribed3.UseVisualStyleBackColor = true;
            this.checkBoxSubscribed3.CheckedChanged += new System.EventHandler(this.checkBoxSubscribed3_CheckedChanged);
            // 
            // textBoxSubscriber3
            // 
            this.textBoxSubscriber3.Location = new System.Drawing.Point(6, 42);
            this.textBoxSubscriber3.Name = "textBoxSubscriber3";
            this.textBoxSubscriber3.ReadOnly = true;
            this.textBoxSubscriber3.Size = new System.Drawing.Size(220, 20);
            this.textBoxSubscriber3.TabIndex = 1;
            // 
            // textBoxSubscriber2
            // 
            this.textBoxSubscriber2.Location = new System.Drawing.Point(6, 42);
            this.textBoxSubscriber2.Name = "textBoxSubscriber2";
            this.textBoxSubscriber2.ReadOnly = true;
            this.textBoxSubscriber2.Size = new System.Drawing.Size(220, 20);
            this.textBoxSubscriber2.TabIndex = 1;
            // 
            // textBoxSubscriber1
            // 
            this.textBoxSubscriber1.Location = new System.Drawing.Point(6, 42);
            this.textBoxSubscriber1.Name = "textBoxSubscriber1";
            this.textBoxSubscriber1.ReadOnly = true;
            this.textBoxSubscriber1.Size = new System.Drawing.Size(220, 20);
            this.textBoxSubscriber1.TabIndex = 1;
            // 
            // FormObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 370);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormObserver";
            this.Text = "FormObserver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.GroupBox groupBox2;
        private SubscriberTextBox textBoxSubscriber1;
        private System.Windows.Forms.CheckBox checkBoxSubscribed1;
        private System.Windows.Forms.GroupBox groupBox3;
        private SubscriberTextBox textBoxSubscriber2;
        private System.Windows.Forms.CheckBox checkBoxSubscribed2;
        private System.Windows.Forms.GroupBox groupBox4;
        private SubscriberTextBox textBoxSubscriber3;
        private System.Windows.Forms.CheckBox checkBoxSubscribed3;
    }
}

