using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    internal interface IPerson
    {
        string Name { get; }
        string FamilyName { get; }
        DateTime DateOfBirth { get; }
    }

    internal class RealPerson : IPerson
    {
        public RealPerson(string name, string familyName, DateTime dateOgBirth)
        {
            Name = name;
            FamilyName = familyName;
            DateOfBirth = DateOfBirth;
        }

        public string Name { get; private set; }

        public string FamilyName { get; private set; }

        public DateTime DateOfBirth { get; private set; }
    }
}
