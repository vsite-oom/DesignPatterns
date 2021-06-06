using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.Observer
{
    public partial class FormObserver : Form
    {
        public FormObserver()
        {
            InitializeComponent();
        }

        private void checkBoxSubscribed1_CheckedChanged(object sender, EventArgs e)
        {
            Subscribe(sender, textBoxSubscriber1);
        }

        private void checkBoxSubscribed2_CheckedChanged(object sender, EventArgs e)
        {
            Subscribe(sender, textBoxSubscriber2);
        }

        private void checkBoxSubscribed3_CheckedChanged(object sender, EventArgs e)
        {
            Subscribe(sender, textBoxSubscriber3);
        }

        private void Subscribe(object sender, SubscriberTextBox subscriber)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Checked)
                    textBoxPublisher.KeyPress += subscriber.Publisher_KeyPress;
                else
                    textBoxPublisher.KeyPress -= subscriber.Publisher_KeyPress;
            }
        }
    }
}
