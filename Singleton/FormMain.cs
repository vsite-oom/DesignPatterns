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
            UserSingleton.Instance.GetValue();
        }

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
            var newForm = new FormMain();
            newForm.ShowDialog(this);
        }
    }
}
