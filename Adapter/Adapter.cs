using System.Linq;
using System.Xml;

namespace DesignPatterns.Adapter
{
    class XmlPersonAdapter
    {
        public XmlPersonAdapter(string filename)
        {
            doc.Load(filename);
        }

        // TODO: 2.0 Implement GetNames using XmlDocument.GetElementsByTagName method.
        public IEnumerable<string> GetNames()
        {
            return doc.GetElementsByTagName("name").Cast<XmlElement>().Select(x => x.InnerText);
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
            {
                Console.WriteLine(name);
            }
        }
    }
}
