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
             textBoxData.Text = UserSingleton.Instance.GetValue();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxData.Clear();
        }
    }
}
