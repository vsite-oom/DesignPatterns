namespace DesignPatterns.Builder
{
    interface IPersonDataBuilder
    {
        string BuildPrologue();
        string BuildName(string name);
        string BuildAddress(string street, string city);
        string BuildEpilogue();
    }

    class XmlPersonDataBuilder : IPersonDataBuilder
    {
        public string BuildAddress(string street, string city)
        {
            return $"\"address\": {{ \"streed\": \"{street}\", \"city\": \"{city}\" }}";
        }

        public string BuildEpilogue()
        {
            return "}";
        }

        public string BuildName(string name)
        {
            return $"\"name:\" \"{ name}\"";
        }

        public string BuildPrologue()
        {
            return "{";
        }
    }

    // TODO: 1.2 Create JsonPersonDataBuilder class and uncomment corresponding code in Main method

    class JsonPersonDataBuilder : IPersonDataBuilder
    {
        public string BuildAddress(string street, string city)
        {
            throw new NotImplementedException();
        }

        public string BuildEpilogue()
        {
            throw new NotImplementedException();
        }

        public string BuildName(string name)
        {
            throw new NotImplementedException();
        }

        public string BuildPrologue()
        {
            throw new NotImplementedException();
        }
    }

}
