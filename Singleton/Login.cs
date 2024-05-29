namespace DesignPatterns.Singleton
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return textBoxUsername.Text; }
        }

        public string Password
        {
            get { return textBoxPassword.Text; }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = textBoxUsername.TextLength > 0 && textBoxPassword.TextLength > 0;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
