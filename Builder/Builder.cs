using System.Text;

namespace DesignPatterns.Builder
{
    struct Person
    {
        public string Name;
        public string StreetAddress;
        public string City;
    }


    class PersonDirector
    {
        public PersonDirector(IPersonDataBuilder builder)
        {
            this.builder = builder;
        }

        private readonly IPersonDataBuilder builder;

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

            PersonDirector xml = new PersonDirector(new XmlPersonDataBuilder());
            Console.WriteLine($"XML Personal data:\n{xml.BuildPersonalData(person)}");

            PersonDirector json = new PersonDirector(new JsonPersonDataBuilder());
            Console.WriteLine($"Json Personal data:\n{json.BuildPersonalData(person)}");
        }
    }
}
