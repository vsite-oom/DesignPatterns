namespace DesignPatterns.Singleton
{
    class UserSingleton
    {
        private static readonly UserSingleton instance = new UserSingleton();

        private UserSingleton()
        {
            LoginForm login = new LoginForm();
            bool validCredentials = false;
            do
            {
                if (login.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (CheckCredentials(login.Username, login.Password))
                    {
                        validCredentials = true;
                        username = login.Username;
                        password = login.Password;
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or pasword.");
                    }
                }
                else
                {
                    MessageBox.Show("Access to data not possible without valid username and password.");
                    break;
                }

            } while (!validCredentials);
        }

        private string username;
        private string password;

        public static UserSingleton Instance
        {
            get { return instance; }
        }

        public string GetValue()
        {
            if (CheckCredentials(username, password))
                return $"{username} + {password}";
            return string.Empty;
        }

        private bool CheckCredentials(string username, string password)
        {
            return username == "user" && password == "user";
        }
    }
}
