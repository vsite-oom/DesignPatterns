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

        // TODO: 3.1 Add code that will unsubscribe observer when checkbox is unchecked
        private void Subscribe(object sender, SubscriberTextBox subscriber)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    textBoxPublisher.KeyPress += subscriber.Publisher_KeyPress;
                }
            }
        }
    }
}
