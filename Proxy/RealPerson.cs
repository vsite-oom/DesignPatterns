namespace DesignPatterns.Proxy
{
    internal interface IPerson
    {
        string Name { get; }
        string FamilyName { get; }
    }

    internal class RealPerson : IPerson
    {
        public RealPerson(string name, string familyName)
        {
            Name = name;
            FamilyName = familyName;
        }

        public string Name { get; private set; }

        public string FamilyName { get; private set; }
    }
}
