namespace DesignPatterns.Singleton
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: 1.4a Fetch and display value from UserSingleton class
            UserSingleton.Instance.GetValue();
        }

        // TODO: 1.4b Add a button to the main form that will open a new instance of the form.

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxData.Clear();
        }

        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            var newForm = new FormMain();
            newForm.ShowDialog(this);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var newForm = new FormMain();
            newForm.ShowDialog(this);
        }
    }
}
