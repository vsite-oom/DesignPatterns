﻿namespace DesignPatterns.Builder
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
    class JsonDataBuilder : IPersonDataBuilder
    {
        public string BuildAddress(string street, string city)
        {
            return $"\"Address\" : {{ \"StreetAddress\"{street}</StreetAddress><City>{city}</City></Address>";
        }

        public string BuildEpilogue()
        {
            return "}}}";
        }

        public string BuildName(string name)
        {
            return $"\"Name\" : \"{name}\", ";
        }

        public string BuildPrologue()
        {
            return "( \" Person \" {";
        }
    }

    // TODO: 013 Create JsonPersonDataBuilder class and uncomment corresponding code in Main method

}
