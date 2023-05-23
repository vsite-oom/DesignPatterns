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
    }
}
