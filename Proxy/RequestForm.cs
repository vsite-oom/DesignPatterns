namespace DesignPatterns.Proxy
{
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
            realPerson = new RealPerson("Bruce Frederick Joseph", " Springsteen");
            personProxy = new PersonProxy(realPerson);
        }

        private readonly RealPerson realPerson;
        private readonly PersonProxy personProxy;

        private void buttonGet_Click(object sender, EventArgs e)
        {
            textBoxName.Text = personProxy.Name;
            // TODO: 2.4 Add code to fill family name and implement fetching in PersonProxy.
        }
    }
}