namespace DesignPatterns.Bridge
{
    class Writer
    {
        private IWriterImplementation implementation;

        public IWriterImplementation Implementation
        {
            set { implementation = value; }
        }

        public void WriteName(string name)
        {
            implementation.WriteName(name);
        }

        public void WriteAddress(string address)
        {
            implementation.WriteAddress(address);
        }
    }

    interface IWriterImplementation
    {
        void WriteName(string name);
        void WriteAddress(string address);
    }

    class XmlPersonWriter : IWriterImplementation, IDisposable
    {
        public XmlPersonWriter(string filename)
        {
            streamWriter = new StreamWriter(filename);
            streamWriter.Write("<doc>");
        }

        StreamWriter streamWriter;

        public void WriteName(string name)
        {
            streamWriter.Write($"<name>{name}</name>");
        }

        public void Dispose()
        {
            streamWriter.Write("</doc>");
            streamWriter.Close();
        }

        public void WriteAddress(string address)
        {
            streamWriter.Write($"<address>{address}</address>");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (XmlPersonWriter xml = new XmlPersonWriter("output.xml"))
            {
                Writer w = new Writer();
                w.Implementation = xml;
                w.WriteName("Pero");
                w.WriteAddress("Vlaška 8");
            }
        }
    }
}
