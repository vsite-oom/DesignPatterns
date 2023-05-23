using System.Xml;

namespace DesignPatterns.Adapter
{
    class XmlPersonAdapter
    {
        public XmlPersonAdapter(string filename)
        {
            doc.Load(filename);
        }

        public string[] GetNames()
        {
            List<string> result = new List<string>();
            foreach (var element in doc.GetElementsByTagName("name"))
            {
                result.Add(((XmlElement)element).InnerText);
            }
            return result.ToArray();
        }
        // https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmldocument
        readonly XmlDocument doc = new XmlDocument();
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            XmlPersonAdapter adapter = new XmlPersonAdapter("names.xml");
            foreach (var name in adapter.GetNames())
                Console.WriteLine(name);
        }
    }
}
