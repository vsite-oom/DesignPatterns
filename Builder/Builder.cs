using System.Text;

namespace DesignPatterns.Builder
{
    interface IPersonBuilder
    {
        string BuildPrologue();
        string BuildName(string name);
        string BuildAddress(string street, string city);
        string BuildEpilogue();
    }

    class XmlPersonBuilder : IPersonBuilder
    {
        public string BuildAddress(string street, string city)
        {
            return $"<Address><StreetAddress>{street}</StreetAddress><City>{city}</City></Address>";
        }

        public string BuildEpilogue()
        {
            return "</Person>";
        }

        public string BuildName(string name)
        {
            return $"<Name>{name}</Name>";
        }

        public string BuildPrologue()
        {
            return "<Person>";
        }
    }

    class JsonPersonBuilder : IPersonBuilder
    {
        public string BuildAddress(string street, string city)
        {
            return $",\"address:\"{{\"streetAddress\":\"{street}\",\"city\":\"{city}\"}}";
        }

        public string BuildEpilogue()
        {
            return "}";
        }

        public string BuildName(string name)
        {
            return $"\"name\":\"{name}\"";
        }

        public string BuildPrologue()
        {
            return "{";
        }
    }

    struct Person
    {
        public string Name;
        public string StreetAddress;
        public string City;
    }

    class PersonDirector
    {
        public PersonDirector(IPersonBuilder builder)
        {
            this.builder = builder;
        }

        private readonly IPersonBuilder builder;

        public string BuildPersonalData(Person data)
        {
            StringBuilder result = new StringBuilder(builder.BuildPrologue());
            result.Append(builder.BuildName(data.Name));
            result.Append(builder.BuildAddress(data.StreetAddress, data.City));
            result.Append(builder.BuildEpilogue());
            return result.ToString();
        }
    }

    static internal class Program
    {
        static void Main()
        {
            Person person = new Person() { Name = "Pero", City = "Zagreb", StreetAddress = "Petrinjska 13" };

            PersonDirector xml = new PersonDirector(new XmlPersonBuilder());
            Console.WriteLine($"XML Personal data:\n{xml.BuildPersonalData(person)}");

            PersonDirector json = new PersonDirector(new JsonPersonBuilder());
            Console.WriteLine($"Json Personal data:\n{json.BuildPersonalData(person)}");
        }
    }
}
