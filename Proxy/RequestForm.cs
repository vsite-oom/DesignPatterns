namespace DesignPatterns.Proxy
{
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
            realPerson = new RealPerson("Bruce Frederick Joseph", " Springsteen", new DateTime(1949, 9, 23));
            personProxy = new PersonProxy(realPerson);
        }

        private readonly RealPerson realPerson;
        private readonly PersonProxy personProxy;

        private void buttonGet_Click(object sender, EventArgs e)
        {
            textBoxName.Text = personProxy.Name;
            // TODO: 025 Add code to fill family name and date of birth and implement fetching in PersonProxy
        }
    }
}