﻿namespace DesignPatterns.Proxy
{
    internal class PersonProxy : IPerson
    {
        public PersonProxy(RealPerson realPerson)
        {
            this.realPerson = realPerson;
        }

        private readonly RealPerson realPerson;

        Dictionary<string, object> values = new Dictionary<string, object>();

        public string Name
        {
            get
            {
                if (values.TryGetValue("Name", out object name))
                {
                    return $"Cached: {name}";
                }
                name = realPerson.Name;
                values.Add("Name", name);
                return (string)name;
            }
        }

        public string FamilyName => throw new NotImplementedException();

        public DateTime DateOfBirth => throw new NotImplementedException();
    }
}