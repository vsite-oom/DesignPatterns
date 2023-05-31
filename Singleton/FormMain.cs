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
            var data = UserSingleton.Instance.GetValue();
            textBoxData.Text = data;
            // TODO: 015a Fetch and display value from UserSingleton class
        }

        // TODO: 015b Add a button to the main form that will open a new instance of the form.

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxData.Clear();
        }

        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            var newForm = new FormMain();
            newForm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
